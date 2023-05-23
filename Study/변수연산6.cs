// 문자열과 숫자 연결하기
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str = "happy ";
        int num = 123;

        string message = str + num;
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
