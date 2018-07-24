using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManager : MonoBehaviour {

    public float timeSpawn = 5;
    public GameObject Particle;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(parti());

    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator parti()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeSpawn);
            Instantiate(Particle, new Vector2(Random.Range(-14, 14), 6), this.transform.rotation);
        }
    }
}
