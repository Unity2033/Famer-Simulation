using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timmy : MonoBehaviour
{
    private Animator animator;
    private Vector3 direction;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("X", Input.GetAxis("Horizontal"));
        animator.SetFloat("Y", Input.GetAxis("Vertical"));
    }
}
