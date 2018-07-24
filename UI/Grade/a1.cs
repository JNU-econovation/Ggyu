using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class a1 : MonoBehaviour {
    public Sprite zero;
    public Sprite a;
    public Sprite b;
    public Sprite c;
    public Sprite d;
    public Sprite e;

    public string str;
    // Use this for initialization
    void Start () {

        if(PlayerPrefs.GetInt(str) ==5)
        {
            gameObject.GetComponent<Image>().sprite = a;
        }
        if (PlayerPrefs.GetInt(str) == 4)
        {
            gameObject.GetComponent<Image>().sprite = b;
        }
        if (PlayerPrefs.GetInt(str) == 3)
        {
            gameObject.GetComponent<Image>().sprite = c;
        }
        if (PlayerPrefs.GetInt(str) == 2)
        {
            gameObject.GetComponent<Image>().sprite = d;
        }
        if (PlayerPrefs.GetInt(str) == 1)
        {
            gameObject.GetComponent<Image>().sprite = e;
        }
        if (PlayerPrefs.GetInt(str) == 0)
        {
            gameObject.GetComponent<Image>().sprite = zero;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
