using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASDF : MonoBehaviour {
    public GameObject A;
    Rigidbody2D rgdy;
	// Use this for initialization
	void Start () {
        rgdy = A.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(rgdy.velocity.y);
	}
}
