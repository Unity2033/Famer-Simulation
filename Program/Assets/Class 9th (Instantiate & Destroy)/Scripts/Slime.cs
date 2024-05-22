using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Unit
{
    void Start()
    {
        health = 75;
        attack = 10.0f;
        name = "Slime";
    }

    public override void Move()
    {
        Debug.Log("Slime Move");
    }
}
