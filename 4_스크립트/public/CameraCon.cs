using UnityEngine;
using System.Collections;

public class CameraCon : MonoBehaviour
{
    public GameObject player;  //A라는 GameObject변수 선언
    public GameObject pan;  //A라는 GameObject변수 선언
    Transform AT;
    Transform DT;
    void Start()
    {
        AT = player.transform;
        DT = pan.transform;
    }

    void ending()
    {
        transform.position = new Vector3(DT.position.x, DT.position.y, transform.position.z);
    }

    void LateUpdate()
    {
        if (ClearCount.clear_count == 0)
            Invoke("ending", 1);
        else
            transform.position = new Vector3(AT.position.x, AT.position.y, transform.position.z);
    }
}