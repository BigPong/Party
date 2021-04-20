﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;
using DG.Tweening;
using UnityEngine.Playables;

public class Tutorial : MonoBehaviour
{
    public int num = -1;

    [SerializeField]
    CinemachineTargetGroup CineGroup;
    [SerializeField]
    GameObject Teacher;
    [SerializeField]
    GameObject DialogueBubble;

    [SerializeField]
    GameObject bomb;

    [SerializeField]
    FacilityArea MoveArea;

    [SerializeField]
    GameObject FireBallSpawn;

    [SerializeField]
    GameObject EnhanceTable;

    [SerializeField]
    PlayerHitten Doll;
    [SerializeField]
    PlayerHitten Doll2;

    [SerializeField]
    TMP_Animated textMesh;

    [SerializeField]
    TextMeshPro textMeshPro;

    [SerializeField]
    PlayableDirector[] hintDirector;

    Coroutine coroutine;
    [SerializeField]
    AudioSource voiceSource;
    [SerializeField]
    AudioClip[] voices;

    [SerializeField]
    PlayableDirector FinishTimeline;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (num)
        {
            // Move to master
            case 0:
                if(StageManager.players.Count == MoveArea.PlayersNum && MoveArea.PlayersNum != 0)
                {
                    num++;
                    coroutine = StartCoroutine(Step1());
                }
                break;
            // Use Fire ball kill enemy
            case 1:
                if (Doll.Dead)
                {
                    num++;
                    StopCoroutine(coroutine);
                    coroutine = StartCoroutine(Step2());
                }
                break;
            // Use Bomb kill enemy
            case 2:
                if (Doll2.Dead)
                {
                    num++;
                    StopCoroutine(coroutine);
                    coroutine = StartCoroutine(Step3());
                }
                break;
            case 3:
                if (EnhanceTable == null)
                {
                    num++;
                    StopCoroutine(coroutine);
                    coroutine = StartCoroutine(Step4());
                }
                break;
            default:
                break;
        }
    }

    public void TutorialStart()
    {
        num = 0;
        CineGroup.AddMember(Teacher.transform, 0.2f, 0);
        DialogueBubble.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        textMesh.ReadText("Come here!");
    }

    void PlaySound()
    {
        voiceSource.clip = voices[Random.Range(0, voices.Length)];
        voiceSource.Play();
    }
    

    IEnumerator Step1()
    {
        textMesh.ReadText("Seems you are here to study magic.");
        PlaySound();
        Destroy(MoveArea.gameObject);
        yield return new WaitForSeconds(3.5f);

        textMesh.ReadText("Great! Now I'm going to teach you the basic of magic.");
        PlaySound();
        yield return new WaitForSeconds(3.5f);

        textMesh.ReadText("I will create some magic books and dummy.");
        PlaySound();
        yield return new WaitForSeconds(3.5f);

        FireBallSpawn.SetActive(true);
        hintDirector[0].Play();
        Doll.gameObject.SetActive(true);
        textMesh.ReadText("Now use your magic destroy the dummy.");
        PlaySound();
        yield return new WaitForSeconds(4f);
        DialogueBubble.transform.DOScale(new Vector3(1, 0, 1), 0.2f);

        yield return null;
    }

    IEnumerator Step2()
    {
        DialogueBubble.transform.DOKill();
        DialogueBubble.transform.DOScale(new Vector3(1, 1, 1), 0.4f);
        textMesh.ReadText("Well Done!");
        PlaySound();
        hintDirector[0].time = 0;
        hintDirector[0].initialTime = 0;
        hintDirector[0].Evaluate();
        hintDirector[0].Stop();
        yield return new WaitForSeconds(2f);

        textMesh.ReadText("There will be lots of different magic books.");
        PlaySound();
        yield return new WaitForSeconds(3.5f);

        textMesh.ReadText("But they are used in same way.");
        PlaySound();
        yield return new WaitForSeconds(3f);

        textMesh.ReadText("Now let's study how to use bomb.");
        PlaySound();
        Destroy(FireBallSpawn);
        yield return new WaitForSeconds(3f);
        bomb.SetActive(true);
        hintDirector[1].Play();
        hintDirector[2].Play();
        Doll2.gameObject.SetActive(true);
        DialogueBubble.transform.DOScale(new Vector3(1, 0, 1), 0.2f);
        yield return null;
    }

    IEnumerator Step3()
    {
        DialogueBubble.transform.DOKill();
        DialogueBubble.transform.DOScale(new Vector3(1, 1, 1), 0.4f);
        textMesh.ReadText("EXCELLENT!");
        PlaySound();
        hintDirector[1].time = 0;
        hintDirector[1].initialTime = 0;
        hintDirector[1].Evaluate();
        hintDirector[1].Stop();
        hintDirector[2].time = 0;
        hintDirector[2].initialTime = 0;
        hintDirector[2].Evaluate();
        hintDirector[2].Stop();
        yield return new WaitForSeconds(2f);

        textMesh.ReadText("Let's do the final part.");
        PlaySound();
        yield return new WaitForSeconds(2.5f);

        textMesh.ReadText("Sometimes you will find enhance table.");
        PlaySound();
        yield return new WaitForSeconds(3f);

        textMesh.ReadText("It can make your weapon more powerful.\r\nHave a Try.");
        EnhanceTable.SetActive(true);
        hintDirector[3].Play();
        PlaySound();
        yield return new WaitForSeconds(3.5f);
        DialogueBubble.transform.DOScale(new Vector3(1, 0, 1), 0.2f);
        yield return null;
    }

    IEnumerator Step4()
    {
        DialogueBubble.transform.DOKill();
        DialogueBubble.transform.DOScale(new Vector3(1, 1, 1), 0.4f);
        textMesh.ReadText("You are the most promising apprentice I ever seen!");
        PlaySound();
        hintDirector[3].time = 0;
        hintDirector[3].initialTime = 0;
        hintDirector[3].Evaluate();
        hintDirector[3].Stop();
        yield return new WaitForSeconds(3f);

        textMesh.ReadText("You have study all of basic skills you need.");
        PlaySound();
        yield return new WaitForSeconds(3f);

        textMesh.ReadText("Now use the portal to create chaos.");
        PlaySound();
        yield return new WaitForSeconds(2.5f);
        textMesh.ReadText("Become the true Chaos Master!");
        PlaySound();
        FinishTimeline.Play();
        StageManager.InLobby = true;
        yield return new WaitForSeconds(2.5f);
        DialogueBubble.transform.DOScale(new Vector3(1, 0, 1), 0.2f);

        yield return null;
    }
}
