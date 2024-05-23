using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    public Factory factory;

    private void Awake()
    {
        factory = GetComponent<Factory>();
    }

    void Start()
    {
        // Invoke( ) : 특정한 시간마다 함수를 호출하는 함수입니다.
        InvokeRepeating(nameof(Use), 1, 5);
    }

    public void Use()
    {
        int select = Random.Range(0, 2);

        factory.Create((UnitType)select);
    }

}
