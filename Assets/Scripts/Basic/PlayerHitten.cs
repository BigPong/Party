﻿using AnimFollow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHitten : MonoBehaviour
{
    [SerializeField]
    RagdollControl_AF ragdollControl;

    PlayerBehavior pickItem;

    public bool test;
    public Transform Hips;
    public Transform foot;
    public Transform FaceWay;
    public GameObject Decal;

    [Header("Health & UI")]
    [SerializeField]
    float MaxHealth;
    public float GetMaxHealth()
    {
        return MaxHealth;
    }

    public static int TestHP = 0;

    float Health;

    [SerializeField]
    GameObject PlayerUI;
    GameObject UI_copy;

    public delegate void PlayerHealthChangedHandler(PlayerHitten source, float oldHealth, float newHealth);
    public event PlayerHealthChangedHandler OnHealthChanged;

    public FlagScore Flag;
    // Start is called before the first frame update
    void Start()
    {
        pickItem = GetComponentInChildren<PlayerBehavior>();

        Health = MaxHealth;

        UI_copy = Instantiate(PlayerUI);
        UI_copy.GetComponent<PlayerUI>().SetUp(this);

        GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
        if (canvas != null)
        {
            UI_copy.transform.parent = canvas.transform;
            UI_copy.transform.localScale = new Vector3(1, 1, 1);
            switch (TestHP)
            {
                case 0:
                    UI_copy.GetComponent<RectTransform>().anchoredPosition = new Vector2(-270, 170);
                    break;
                case 1:
                    UI_copy.GetComponent<RectTransform>().anchoredPosition = new Vector2(270, 170);
                    break;
                case 2:
                    UI_copy.GetComponent<RectTransform>().anchoredPosition = new Vector2(-270, -170);
                    break;
            }
            TestHP++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Decal.transform.position = Hips.transform.position;
        Vector3 v = Decal.transform.position;
        v.y = foot.position.y;
        // Decal.transform.position = v;
    }
    public void OnHit(BulletHitInfo_AF info)
    {
        if (Flag != null) Flag.Throw();
        Flag = null;


        StartCoroutine(AddForceToLimb(info));

        if (ragdollControl.shotByBullet) return;

        ragdollControl.shotByBullet = true;
        pickItem.OnHit(info);
    }

    IEnumerator Respawn()
    {
        yield return new WaitForFixedUpdate();
        BulletHitInfo_AF info = new BulletHitInfo_AF();
        pickItem.OnHit(info);
        yield return new WaitForFixedUpdate();
        ragdollControl.shotByBullet = true;
        ragdollControl.IsDead = true;
        yield return new WaitForSeconds(2f);
        GetComponent<PlayerIdentity>().Respawn();
        Health = MaxHealth;
        ragdollControl.IsDead = false;
        yield return null;
    }

    public void OnDamaged(float damage)
    {
        if (ragdollControl.shotByBullet) return;

        float oldH = Health;
        Health -= damage;
        Health = Mathf.Max(0, Health);
        if (Health == 0)
        {
            StartCoroutine(Respawn());
        }

        OnHealthChanged?.Invoke(this, oldH, Health);
    }

    public bool IsGettingUp()
    {
        return ragdollControl.PlayerInhibit();
    }

    IEnumerator AddForceToLimb(BulletHitInfo_AF bulletHitInfo)
    {
        yield return new WaitForFixedUpdate();
        if (bulletHitInfo.hitPoint != null)
        {
            bulletHitInfo.hitTransform.GetComponent<Rigidbody>().AddForceAtPosition(bulletHitInfo.bulletForce, bulletHitInfo.hitPoint);
        }

    }
}
