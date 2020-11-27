﻿using AnimFollow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.Haptics;

public class PlayerHitten : MonoBehaviour
{
    [SerializeField]
    RagdollControl_AF ragdollControl;

    PlayerBehavior pickItem;
    public PlayerMove playerMove;
    PlayerInput playerInput;
    PlayerIdentity playerIdentity;

    public bool test;
    public Transform Hips;
    public Transform foot;
    public Transform FaceWay;

    [Header("FX")]
    public GameObject Decal;
    public GameObject RespawnPortal;

    [Header("Health & UI")]
    [SerializeField]
    float MaxHealth;
    public float GetMaxHealth()
    {
        return MaxHealth;
    }

    public static int TestHP = 0;

    float Health;
    public bool Dead = false;
    public bool IsInvincible = false;
    bool Respawnable = true;
    public void SetRespawnable(bool b)
    {
        Respawnable = b;
    }

    [SerializeField]
    GameObject PlayerUI;
    GameObject UI_copy;

    public delegate void PlayerHealthChangedHandler(PlayerHitten source, float oldHealth, float newHealth);
    public event PlayerHealthChangedHandler OnHealthChanged;

    public delegate void PlayerDeathHandler(PlayerHitten source);
    public event PlayerDeathHandler OnDeath;

    public FlagScore Flag;
    public int LastDamagedID = -1;
    Gamepad gamepad;
    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponentInChildren<PlayerInput>();
        pickItem = GetComponentInChildren<PlayerBehavior>();
        playerMove = GetComponentInChildren<PlayerMove>();
        playerIdentity = GetComponentInChildren<PlayerIdentity>();

        Health = MaxHealth;
        Dead = false;
        Respawnable = true;

        if (StageManager.Static_Testing)
        {
            UI_copy = Instantiate(PlayerUI);
            UI_copy.GetComponent<PlayerUI>().SetUp(this);

            GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
            if (canvas != null)
            {
                UI_copy.transform.parent = canvas.transform;
                UI_copy.transform.localScale = new Vector3(1, 1, 1);
            }
        }

        for(int i = 0; i < Gamepad.all.Count; i++)
        {
            if(Gamepad.all[i].name == playerInput.devices[0].name)
            {
                gamepad = Gamepad.all[i];
            }
        }
    }

    public void Refresh()
    {
        playerIdentity.ResetStageData();

        Health = MaxHealth;
        Dead = false;
        Respawnable = true;

        UI_copy = Instantiate(PlayerUI);
        UI_copy.GetComponent<PlayerUI>().SetUp(this);

        GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
        if (canvas != null)
        {
            UI_copy.transform.parent = canvas.transform;
            UI_copy.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

        Decal.transform.position = Hips.transform.position;
        /*Vector3 v = Decal.transform.position;
        v.y = foot.position.y;
        Decal.transform.position = v;*/

        if (IsInvincible)
        {
            playerIdentity.SetPlayerMaterial(0, "_Fresnel_Bias", Mathf.PingPong(Time.time * 0.7f, 0.25f));
        }
        else
        {
            playerIdentity.SetPlayerMaterial(0, "_Fresnel_Bias", 0);
        }
    }
    public void OnHit(BulletHitInfo_AF info)
    {


        StartCoroutine(AddForceToLimb(info));

        if (ragdollControl.shotByBullet) return;

        if (info.IsShot)
        {
            ragdollControl.shotByBullet = true;
        }
        else
        {

        }
        if (!IsInvincible)
        {
            pickItem.OnHit(info);
        }
    }

    IEnumerator Respawn(float time)
    {
        yield return new WaitForFixedUpdate();
        ragdollControl.shotByBullet = true;
        ragdollControl.IsDead = true;
        pickItem.OnHit();
        yield return new WaitForFixedUpdate();
        if (Flag != null) Flag.Throw();
        Flag = null;
        yield return new WaitForSeconds(time);
        if (Respawnable)
        {
            playerIdentity.Respawn();
            IsInvincible = true;
            LastDamagedID = -1;
            ragdollControl.shotByBullet = true;
            Health = MaxHealth;
            OnHealthChanged?.Invoke(this, 0, Health);
            ragdollControl.IsDead = false;
        }
        yield return new WaitForSeconds(4.5f);
        Dead = false;
        IsInvincible = false;
        yield return null;
    }

    public void OnDamaged(float damage, int ID)
    {
        if (ragdollControl.shotByBullet || Dead || IsInvincible) return;


        float oldH = Health;
        Health -= damage;
        Health = Mathf.Max(0, Health);

        if (ID != playerIdentity.PlayerID)
        {
            BattleData.AddDamage(ID, damage);
            LastDamagedID = ID;
        }

        OnHealthChanged?.Invoke(this, oldH, Health);

        if (Health <= 0)
        {
            StartCoroutine(Respawn(2));
            OnDeath?.Invoke(this);
            Dead = true;
        }

    }

    // Testing
    public void AddtionalDeath()
    {
        if (Dead || !Respawnable) return;
        Dead = true;
        StartCoroutine(Respawn(0.1f));
        OnDeath?.Invoke(this);
    }

    public bool IsGettingUp()
    {
        return ragdollControl.PlayerInhibit();
    }

    IEnumerator AddForceToLimb(BulletHitInfo_AF bulletHitInfo)
    {
        if (!IsInvincible)
        {
            yield return new WaitForFixedUpdate();
            if (bulletHitInfo.hitTransform != null)
            {
                if (bulletHitInfo.hitTransform.GetComponent<Rigidbody>() != null) bulletHitInfo.hitTransform.GetComponent<Rigidbody>().AddForceAtPosition(bulletHitInfo.bulletForce, bulletHitInfo.hitPoint);
            }
            playerMove.AddForceSpeed(bulletHitInfo.bulletForce / 100f);

            // 最好設成一個Global Ienumertor 比較方便
            if (gamepad != null)
            {
                gamepad.SetMotorSpeeds(0.8f, 1f);
                yield return new WaitForSecondsRealtime(0.2f);
                gamepad.PauseHaptics();
            }
        }
    }
}
