using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

    public GameObject outdoor;
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void playSound(string snd)
    {
        GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            playSound("TPSound");
            player.transform.position = outdoor.transform.position;
        }
    }
}
