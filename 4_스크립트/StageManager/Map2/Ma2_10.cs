﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ma2_10 : MonoBehaviour                         //  이름변경
{
    
    public static int limit = 60;
    public UnityEngine.UI.Image Fade;

    public GameObject Clear;
    public GameObject grid;
    void Start()
    {
        StartCoroutine("FadeIn");

        ClearCount.clear_count = 4;                        // 스테이지 별갯수
        ClearCount.RotNum = 0;
    }
    void Next_Stage()
    {
        Clear.SetActive(true);
        grid.SetActive(false);
        if (Input.GetKey("space"))
        {
            if (End.grade > PlayerPrefs.GetInt("b10", 0))   // aN
            {
                PlayerPrefs.SetInt("b10", End.grade);       // aN
            }
            Debug.Log(PlayerPrefs.GetInt("b10"));           // aN
            StartCoroutine("FadeOut");
        }
        else if (Input.GetKey(KeyCode.R))
        {
            RSBtn();
        }
    }
    void ReStart()
    {
        limit = 60;
        SceneManager.LoadScene("2_10");                      // aN
    }
    void Update()
    {
        if (limit - ClearCount.RotNum < 0)
            ReStart();
        if (ClearCount.clear_count == 0)
        {
            if (PlayerPrefs.GetInt("Score") < 21)           // N+1
            {
                ClearCount.score = 21;                      // N+1
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
        SceneManager.LoadScene("4_1");                   // N+1
        yield return null;
    }
    public void RSBtn()
    {
        SceneManager.LoadScene("2_10");                   // _N
    }
    public void LBBtn()
    {
        SceneManager.LoadScene("Main");
    }
}
