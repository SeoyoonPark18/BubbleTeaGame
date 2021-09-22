using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Drink_Decrease : MonoBehaviour
{
    GameObject drink; 
    int amount = 20; //음료가 줄어들 횟수

    void Start()
    {
        this.drink = GameObject.Find("Drink"); //음료(액체) 부분인 Drink 오브젝트 찾아서 대입
        InvokeRepeating("Decrease", 3f, 2f); //반복메소드 사용, Decrease 메소드를 3초 후부터 2초마다 반복 호출
        
    }
 
    void Decrease() //음료 감소를 위한 메소드
    {
        this.drink.GetComponent<Image>().fillAmount -= 0.05f; //이미지 UI의 fillAmount 값을 이용해 음료량 5%씩 감소
        amount--; // 횟수도 같이 차감
    }

    void Update()
    {
        if (amount == 0) //차감 횟수가 0이 되면, 즉 음료가 다 사라지면
        {
            SceneManager.LoadScene("GameOver"); //GameOver 씬으로 이동
        }
       
    }
}
