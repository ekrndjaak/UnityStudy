// if ~ else 문 사용하기
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int hp = 200;
        if (hp >= 100)
        {
            Debug.Log("공격!");
        }
        else
        {
            Debug.Log("방어!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
