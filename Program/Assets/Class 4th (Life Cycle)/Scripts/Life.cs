using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Awake 함수
    // 게임 오브젝트가 인스턴스된 후에 단 한 번만 호출되며,
    // 스크립트가 비활성화되었을 때도 호출되는 이벤트 함수입니다.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // OnEnable
    // 게임 오브젝트 활성화되었을 때 호출되는 이벤트 함수입니다.
    private void OnEnable()
    {
        Debug.Log("OnEnable");        
    }

    // Start
    // 게임 오브젝트가 인스턴스된 후에 단 한 번만 호출되며,
    // 스크립트가 활성화되었을 때만, 호출되는 이벤트 함수입니다.
    void Start()
    {
        Debug.Log("Start");
    }

    // FixedUpdate
    // TimeStep에 설정된 값에 따라 일정한 간격으로 호출되는
    // 이벤트 함수입니다.
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }
    
    // Update
    // 매 프레임마다 호출되는 이벤트 함수입니다.
    void Update()
    {
        Debug.Log("Update");
    }
    
    // LateUpdate
    // Update함수가 끝난 후에 호출되는 이벤트 함수입니다.
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    // OnDisable
    // 게임 오브젝트 비활성화되었을 때 호출되는 이벤트 함수입니다.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // OnDestroy
    // 게임 오브젝트가 파괴되었을 때 호출되는 이벤트 함수입니다.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
