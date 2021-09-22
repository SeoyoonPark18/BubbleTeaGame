using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straw_Move : MonoBehaviour
{
    //키보드 상하좌우 이용하여, 빨대 오브젝트 제어
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //왼쪽으로 이동
        {
            transform.Translate(-0.2f,0,0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) //오른쪽으로 이동
        {
            transform.Translate(0.2f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) //위로 이동
        {
            transform.Translate(0, 0.2f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) //아래로 이동
        {
            transform.Translate(0, -0.2f, 0);
        }
    }
}
