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
       
    }
}
