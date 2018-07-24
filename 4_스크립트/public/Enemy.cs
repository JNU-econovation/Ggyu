using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {
    public GameObject explosion;
    GameObject player;
    public GameObject THEEND;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            player.SetActive(false);
            var myParticle = Instantiate(explosion, player.transform.position, Quaternion.Euler(0, 0, 0));
            THEEND.SetActive(true);
            Invoke("Ma", 3);
        }
    }
    public void Ma()
    {
        SceneManager.LoadScene("Main");
    }
}
