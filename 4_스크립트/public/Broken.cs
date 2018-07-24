using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour {
    GameObject player;
    Rigidbody2D rgdy;
    public GameObject explosion;
    public GameObject Grid;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        rgdy = player.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
      //  Debug.Log(rgdy.velocity.y);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player&& rgdy.velocity.y<-35)
        {
            Destroy(gameObject);
            var myParticle = Instantiate(explosion, this.transform.position, Quaternion.Euler(0, 0, 0));
            //Euler(x,y,z)하면 캐릭터의 회전값을 설정해준다.
            myParticle.transform.parent = Grid.transform;
        }
    }
}
