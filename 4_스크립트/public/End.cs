using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour {

    public int a1,a2,a3,a4,a5;
    public static int grade = 0;
    public Animator ani;
    public GameObject z1, z2, z3, z4, z5;
    int chk = -1;

    // Use this for initialization
    void Start () {
        ani = GetComponent<Animator>();
        StartCoroutine(SD());
        grade = 0;
    }

    void playSound(string snd)
    {
        GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    IEnumerator SD()
    {
        while (chk < grade)
        {
            playSound("ScoreSound");
            yield return new WaitForSeconds(0.25f);
            chk++;
        }
    }

    void Update () {
        if (a1 >= ClearCount.RotNum)
        {
            ani.Play("a5");
            grade = 5;
        }
        else if (a2 > ClearCount.RotNum)
        {
        
            ani.Play("a4");
            grade = 4;
            z5.SetActive(false);
        }
        else if (a3 > ClearCount.RotNum)
        {
          
            ani.Play("a3");
            grade = 3;
            z5.SetActive(false);
            z4.SetActive(false);
        }
        else if (a4 > ClearCount.RotNum)
        {
        
            ani.Play("a2");
            grade = 2;
            z5.SetActive(false);
            z4.SetActive(false);
            z3.SetActive(false);
        }
        else if (a5 > ClearCount.RotNum)
        {
          
            ani.Play("a1");
            grade = 1;
            z5.SetActive(false);
            z4.SetActive(false);
            z3.SetActive(false);
            z2.SetActive(false);
        }
        else    // 이곳 추가됨
        {
            grade = 0;
            z5.SetActive(false);
            z4.SetActive(false);
            z3.SetActive(false);
            z2.SetActive(false);
            z1.SetActive(false);
        }
    }
}
