using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Vector3 _direction;

    public void OnKeyUpdate()
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.z = Input.GetAxisRaw("Vertical");
        _direction.Normalize();
    }


    public void OnMove(Rigidbody rigidbody) => rigidbody.position += rigidbody.transform.TransformDirection(_direction * _speed * Time.deltaTime);

}
