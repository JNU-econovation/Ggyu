using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour {
    
    GameObject player;
    Rigidbody2D rb;
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
            playSound("Gravity Sound");
            rb =player.GetComponent<Rigidbody2D>();
            if (rb.gravityScale > 0)
                rb.gravityScale = -1;
            else
                rb.gravityScale = 1;
            Destroy(gameObject);
        }
    }
    
}
