using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Controller : MonoBehaviour {
    public GameObject explosion;
    public GameObject Grid;
	// Use this for initialization
	void Start () {
	}

    void playSound(string snd)
    {
        GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }

    void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag =="Player") {
            playSound("StarSound");
            var myParticle = Instantiate(explosion, this.transform.position, Quaternion.Euler(0, 0, 0));

            //Euler(x,y,z)하면 캐릭터의 회전값을 설정해준다.
            myParticle.transform.parent = Grid.transform;
            ClearCount.clear_count--;
            Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
