using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp_Controller : MonoBehaviour {
	
	public Transform Tp_out;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		other.transform.position = Tp_out.transform.position;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
