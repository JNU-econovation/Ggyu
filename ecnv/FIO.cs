using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FIO : MonoBehaviour {

    public UnityEngine.UI.Image SR; //추가됨
    public GameObject Part;
    public GameObject Part2;
    // Use this for initialization
    void Start () {
        StartCoroutine("FadeIn");
    }

    IEnumerator FadeIn()
    {
        Color color = SR.color;
        int countTime = 0;
        while (countTime < 10)
        {
            color.a -= 0.1f;
            yield return new WaitForSeconds(0.04f);
            countTime++;
            SR.color = color;
        }
        Part.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        Part2.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countTime = 0;
        while (countTime < 10)
        {
            color.a += 0.1f;
            yield return new WaitForSeconds(0.04f);
            countTime++;
            SR.color = color;
        }
        SceneManager.LoadScene("Main");
        yield return null;
    }
}
