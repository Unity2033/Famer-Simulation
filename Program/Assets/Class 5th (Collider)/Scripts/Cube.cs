using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IDamageable
{
    private int health = 100;

    // OnCollisionEnter
    // 물리적인 충돌을 했을 때 호출되는 이벤트 함수입니다.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    // OnCollisionStay
    // 물리적인 충돌을 하고 있을 때 호출되는 이벤트 함수입니다.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    // OnCollisionExit
    // 물리적인 충돌이 끝났을 때 호출되는 이벤트 함수입니다.
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }

    public void Active()
    {
        health -= 50;

        Debug.Log("Damage를 받았습니다.");
    }
}
