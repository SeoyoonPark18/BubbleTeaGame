using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Stage1"); //마우스 왼쪽 버튼으로 화면 클릭 시 stage1으로 이동 (게임 재시작)
        }
    }
}
