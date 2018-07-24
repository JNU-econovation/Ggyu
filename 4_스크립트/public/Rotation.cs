using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    Rigidbody2D PlayerR;
    GameObject Character;
    bool isPlayer;   // 플레이어 큐브가 움직일 때 입력을 못받게 하기위한 변수
    bool isCube; // 맵 큐브가 회전할 때 입력을 못받게 하기위한 변수
    float cool;
    // Use this for initialization
    void Start () {
        Character = GameObject.Find("Character");
        PlayerR = Character.GetComponent<Rigidbody2D>();
        isPlayer = true;
        isCube = true;
        cool = 0.7f;
    }

    void playSound(string snd)
    {
        GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }

    void FixedUpdate()
    {
        if ((int)PlayerR.velocity.y != 0)
        {
            isPlayer = false;
            cool = 0;
        }
        else
            isPlayer = true;
        if(cool<0.4)
        cool += Time.deltaTime;
        //Debug.Log(cool);
    }   

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) && isPlayer == true && isCube == true &&cool>=0.35)
        {
            ClearCount.RotNum++;
            isCube = false;
            PlayerR.isKinematic = true;
            StartCoroutine("RightRot");  
            cool = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && isPlayer == true && isCube == true && cool >= 0.35)
        {
            ClearCount.RotNum++;
            isCube = false;
            PlayerR.isKinematic = true;
            StartCoroutine("LeftRot");
            cool = 0;
        }
    }

    IEnumerator RightRot()
    {
        int countTime = 0;
        while (countTime < 10)
        {
            transform.Rotate(0, 0, -9);
            yield return new WaitForSeconds(0.005f);
            countTime++;
        }
        Character.transform.Rotate(0, 0, 90,Space.Self);
        PlayerR.isKinematic = false;
        isCube = true;
        playSound("CSound");
        yield return null;
    }
    IEnumerator LeftRot()
    {
        int countTime = 0;
        while (countTime < 10)
        {
            transform.Rotate(0, 0, 9);
            yield return new WaitForSeconds(0.005f);
            countTime++;
        }

        Character.transform.Rotate(0, 0, 90, Space.Self);
        PlayerR.isKinematic = false;
        isCube = true;
        playSound("CSound");
        yield return null;
    }
}