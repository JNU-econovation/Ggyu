using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ma4_2 : MonoBehaviour
{

    public UnityEngine.UI.Image SR; //추가됨

    public GameObject Clear;
    public GameObject grid;
    void Start()
    {
        StartCoroutine("FadeIn"); // 추가됨

        ClearCount.clear_count = 3;
        ClearCount.RotNum = 0; // 회전수 0으로 초기화
                               // Clear = GameObject.Find("Clear");
    }
    void Next_Stage()
    {
        Clear.SetActive(true);
        grid.SetActive(false);
        if (Input.GetKey("space"))
        {


            if (End.grade > PlayerPrefs.GetInt("c2", 0))   // 점수 저장용
            {
                PlayerPrefs.SetInt("c2", End.grade);
            }
            Debug.Log(PlayerPrefs.GetInt("c2"));


            StartCoroutine("FadeOut");
        }
        else if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("4_2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ClearCount.score = 0;
        if (ClearCount.clear_count == 0)
        {
            if (PlayerPrefs.GetInt("Score") < 23)     //최고스테이지가 이번스테이지가 아닐경우는  if문을 들어가지 않는다
            {
                ClearCount.score = 23;    // if속으로 들어오면 score값 변화
                PlayerPrefs.SetInt("Score", ClearCount.score);
            }
            Invoke("Next_Stage", 1);
        }
        //Debug.Log(ClearCount.score);
    }
    IEnumerator FadeIn()
    {
        Color color = SR.color;
        int countTime = 0;
        while (countTime < 10)
        {
            color.a -= 0.1f;
            yield return new WaitForSeconds(0.04f);
            countTime++;
            SR.color = color;
        }
        yield return null;
    }

    IEnumerator FadeOut()
    {
        Color color = SR.color;

        int countTime = 0;
        while (countTime < 10)
        {
            color.a += 0.1f;
            yield return new WaitForSeconds(0.04f);
            countTime++;
            SR.color = color;
        }
        SceneManager.LoadScene("4_3");
        yield return null;
    }
    public void RSBtn()
    {
        SceneManager.LoadScene("4_2");                   // _N
    }
    public void LBBtn()
    {
        SceneManager.LoadScene("Main");
    }
}