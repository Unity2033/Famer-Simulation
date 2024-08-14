using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraft : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Vector3 direction;

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize();

        // P = P0 + vt
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
