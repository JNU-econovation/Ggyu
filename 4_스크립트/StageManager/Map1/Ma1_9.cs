﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ma1_9 : MonoBehaviour                         //  이름변경
{
    public static int limit = 17;
    public UnityEngine.UI.Image Fade;

    public GameObject Clear;
    public GameObject grid;
    void Start()
    {
        StartCoroutine("FadeIn");

        ClearCount.clear_count = 5;                        // 스테이지 별갯수
        ClearCount.RotNum = 0;
    }
    void ReStart()
    {
        limit = 17;
        SceneManager.LoadScene("1_9");                      // aN
    }

    void Next_Stage()
    {
        Clear.SetActive(true);
        grid.SetActive(false);
        if (Input.GetKey("space"))
        {


            if (End.grade > PlayerPrefs.GetInt("a9", 0))   // aN
            {
                PlayerPrefs.SetInt("a9", End.grade);       // aN
            }
            Debug.Log(PlayerPrefs.GetInt("a9"));           // aN


            StartCoroutine("FadeOut");
        }
        else if (Input.GetKey(KeyCode.R))
        {
            RSBtn();
        }
    }

    void Update()
    {
        if (limit - ClearCount.RotNum < 0)
            ReStart();

        if (ClearCount.clear_count == 0)
        {
            if (PlayerPrefs.GetInt("Score") < 10)           // N+1
            {
                ClearCount.score = 10;                      // N+1
                PlayerPrefs.SetInt("Score", ClearCount.score);
            }
            Invoke("Next_Stage", 1);
        }
    }
    IEnumerator FadeIn()
    {
        Color color = Fade.color;
        int countTime = 0;
        while (countTime < 10)
        {
            color.a -= 0.1f;
            yield return new WaitForSeconds(0.04f);
            countTime++;
            Fade.color = color;
        }
        yield return null;
    }

    IEnumerator FadeOut()
    {
        Color color = Fade.color;

        int countTime = 0;
        while (countTime < 10)
        {
            color.a += 0.1f;
            yield return new WaitForSeconds(0.04f);
            countTime++;
            Fade.color = color;
        }
        SceneManager.LoadScene("1_10");                   // N+1
        yield return null;
    }
    public void RSBtn()
    {
        SceneManager.LoadScene("1_9");                   // _N
    }
    public void LBBtn()
    {
        SceneManager.LoadScene("Main");
    }
}
