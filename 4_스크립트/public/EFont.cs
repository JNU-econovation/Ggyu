using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EFont : MonoBehaviour
{
    SpriteRenderer SR;
    // Use this for initialization
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        StartCoroutine("Write");
    }

    // Update is called once per frame
    void Update()
    {
    }

    // IEnumerator Write()
    //{
    //  Color color = SR.color;
    ////     color.a = Mathf.Lerp(start, end, time);
    //}
    IEnumerator Write()
    {
        Color color = SR.color;

        int countTime = 0;
        while (true)
        {
            countTime = 0;
            while (countTime < 10)
            {
                color.a -= 0.1f;
                yield return new WaitForSeconds(0.04f);
                countTime++;
                SR.color = color;
            }
            countTime = 0;
            while (countTime < 10)
            {
                color.a += 0.1f;
                yield return new WaitForSeconds(0.04f);
                countTime++;
                SR.color = color;
            }
        }
    }
}