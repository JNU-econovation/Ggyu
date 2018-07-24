using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MT : MonoBehaviour {
    public Sprite ON;
    public Sprite OFF;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (AudioListener.pause)
            gameObject.GetComponent<Image>().sprite = ON;
        if (!AudioListener.pause)
            gameObject.GetComponent<Image>().sprite = OFF;

    }
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
