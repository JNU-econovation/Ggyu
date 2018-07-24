using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Txt : MonoBehaviour
{
    Text CCtext;
    // Use this for initialization
    void Start()    
    {
        CCtext = GetComponent<Text>();
        ClearCount.score = PlayerPrefs.GetInt("Score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        CCtext.text = "level: " + ClearCount.score;
        Debug.Log(ClearCount.score);
    }
}
