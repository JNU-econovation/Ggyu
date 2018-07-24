using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {
    GameObject player;
    Rigidbody2D rgdy;
    public GameObject A;
    Vector3 POS;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rgdy = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        POS = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player && rgdy.velocity.y < -20)
        {
            POS.y -= 1.25f;
            Debug.Log("hi");
            transform.position = POS;
        }
    }
}
