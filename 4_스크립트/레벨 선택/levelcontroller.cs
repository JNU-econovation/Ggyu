using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontroller : MonoBehaviour
{
    public static int level = 1;
    public GameObject[] UL;
    string del = "UL";
    // int index;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //i = ClearCount.score - 1;
        for (int i = 0; i < PlayerPrefs.GetInt("Score"); i++)
        {
            Destroy(UL[i]);
        }
        Debug.Log(PlayerPrefs.GetInt("Score"));
    }
}
