using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 direction;
    private float speed = 5.0f;
    private Rigidbody rigidBody;

    public GameManager gameManager;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (gameManager.State == false)
        {
            return;
        }

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce
        (
            direction * speed * Time.fixedDeltaTime, 
            ForceMode.Impulse
        );
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit");
    }
}
