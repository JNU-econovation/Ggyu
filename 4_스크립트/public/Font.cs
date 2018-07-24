using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Font : MonoBehaviour {
    SpriteRenderer SR;
    // Use this for initialization
    void Start() {
        SR = GetComponent<SpriteRenderer>();
        StartCoroutine("Write");
    }

    // Update is called once per frame
    void Update() {
    }

    // IEnumerator Write()
    //{
    //  Color color = SR.color;
    ////     color.a = Mathf.Lerp(start, end, time);
    //}
    IEnumerator Write()
    {
        Color color = SR.color;
        yield return new WaitForSeconds(0.5f);
        int countTime = 0;
        while (countTime < 10)
        {
            color.a += 0.1f;
            yield return new WaitForSeconds(0.04f);
            countTime++;
            SR.color = color;
        }
        yield return new WaitForSeconds(2.5f);
        countTime = 0;
        while (countTime < 10)
        {
            color.a -= 0.1f;
            yield return new WaitForSeconds(0.04f);
            countTime++;
            SR.color = color;
        }
        yield return null;
    }
}