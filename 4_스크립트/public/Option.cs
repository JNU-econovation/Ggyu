using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {
    public int width;
    public int height;
    public GameObject OP;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetWidth(int newWidth)
    {
        width = newWidth;
    }
    public void SetHeight(int newHeight)
    {
        height = newHeight;
    }
    public void SetRes()
    {
        Screen.SetResolution(width, height, false);
    }
    public void OPtion()
    {
        OP.SetActive(true);
    }
    public void OPtionF()
    {
        OP.SetActive(false);
    }
}
