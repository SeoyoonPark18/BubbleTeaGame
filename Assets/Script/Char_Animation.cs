using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Animation : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        this.animator = GetComponent<Animator>(); //메인 캐릭터 애니매이션 작업 위해
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) //(Straw_Collision 스크립트 참고) 버블 제거위해 스페이스키를 누르면, 캐릭터도 같은 타이밍에 모션을 취함
        {
            this.animator.SetTrigger("EatTrigger"); //설정한 EatTrigger 이용 (버블을 먹기 위해 입을 벌리는 모션)
        }
        
    }
}
