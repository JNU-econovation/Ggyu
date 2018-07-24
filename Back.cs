using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {
    public GameObject Pan1;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Back1()
    {
        Pan1.SetActive(false);
    }
    public void ch1()
    {
        Pan1.SetActive(true);
        c1.SetActive(false);
    }
    public void ch2()
    {
        Pan1.SetActive(true);
        c2.SetActive(false);
    }
    public void ch3()
    {
        Pan1.SetActive(true);
        c3.SetActive(false);
    }
    public void ch4()
    {
        Pan1.SetActive(true);
        c4.SetActive(false);
    }
}
