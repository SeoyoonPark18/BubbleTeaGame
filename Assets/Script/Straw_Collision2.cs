using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Straw_Collision2 : MonoBehaviour
{
    //Stage2씬용

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bubble") //버블오브젝트에 "bubble" 태그 설정함-> 버블오브젝트에 닿았을 때
        {
            if (Input.GetKey(KeyCode.Space)) //닿은 상태로 스페이브키를 누르면
            {
                Destroy(collision.gameObject); //닿은 버블 오브젝트 제거
            }

        }
    }

    
    void Update()
    {
        GameObject tempObj = null; //임시 오브젝트 생성
        tempObj = GameObject.FindWithTag("bubble"); //태그르 이용해 버블 오브젝트 찾아서 임시 오브젝트에 넣기

        if (tempObj == null) //만약 임시 오브젝트가 비었다면 (버블 오브젝트가 모두 제거되었다면)
        {
            SceneManager.LoadScene("Stage3"); //Stage2 성공, Stage3로 이동
        }
    }
}
