using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : MonoBehaviour
{
    GameObject curObj;
    Rigidbody2D curComp;

    void Start()
    {
        curComp = GetComponent<Rigidbody2D>(); //악당 오브젝트 강체
        curComp.AddForce(new Vector2(-25, 0)); //오브젝트가 컵에 가까이 가도록 강체 이동 (악당 오브젝트가 바늘로 컵을 찌름)
 
        curObj = GameObject.Find("villain"); //현재 오브젝트인 악동오브젝트를 찾아서
        Destroy(curObj, 2); //2초 후 제거
    }
   
}
