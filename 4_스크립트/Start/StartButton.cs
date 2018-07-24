using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public static bool isStart;
    public GameObject startMenu;
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    // public GameObject OptionMenu;

    // Use this for initialization
    void Start()
    {
        isStart = false;
        startMenu.SetActive(false);
        C1.SetActive(false);
        C2.SetActive(false);
        C3.SetActive(false);
        C4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartB()
    {
        startMenu.SetActive(true);
    }
    public void Chap1()
    {
        startMenu.SetActive(false);
        C1.SetActive(true);
    }
    public void Chap2()
    {
        startMenu.SetActive(false);
        C2.SetActive(true);
    }
    public void Chap3()
    {
        startMenu.SetActive(false);
        C3.SetActive(true);
    }
    public void Chap4()
    {
        startMenu.SetActive(false);
        C4.SetActive(true);
    }
}
