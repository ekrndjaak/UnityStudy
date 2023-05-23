// 문자열과 문자열 연결하기
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str1 = "Happy ";
        string str2 = "Birthday";
        string  message;

        message = str1 + str2;
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
