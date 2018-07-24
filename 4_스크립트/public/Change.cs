using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

    public GameObject A;
    public GameObject B;
    Vector2 AT;
    Vector2 BT;
    GameObject player;
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
            AT = A.transform.position;
            BT = B.transform.position;
            Debug.Log("hi222");
            A.transform.position = BT;
            B.transform.position = AT;
            Destroy(gameObject);
        }
    }
}
