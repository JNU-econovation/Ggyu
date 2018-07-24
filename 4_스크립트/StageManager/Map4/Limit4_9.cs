using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Limit4_9 : MonoBehaviour
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
        CCtext.text = "Limit: " + (Ma4_9.limit - ClearCount.RotNum);
    }
}
