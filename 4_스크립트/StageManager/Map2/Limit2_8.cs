﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Limit2_8 : MonoBehaviour
{
    Text CCtext;
    // Use this for initialization
    void Start()
    {
        CCtext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CCtext.text = "Limit: " + (Ma2_8.limit - ClearCount.RotNum);
    }
}
