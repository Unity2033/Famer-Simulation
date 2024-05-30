using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capsule : MonoBehaviour
{
    private float health;
    private float maxHealth;

    public Slider slider;

    void Start()
    {
        health = 100;
        maxHealth = health;
    }

    public void Damage(float damage)
    {
        if (health > 0)
        {
            health -= damage;

            slider.value = health / maxHealth;
        }
    }
}
