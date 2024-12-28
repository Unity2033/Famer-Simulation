using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] float _speed;
    [SerializeField] float _mouseX;
    [SerializeField] float _mouseY;


    public void RotateX()
    {
        _mouseY += Input.GetAxisRaw("Mouse Y") * _speed * Time.deltaTime;
        _mouseY = Mathf.Clamp(_mouseY, -65, 65);
        transform.localEulerAngles = new Vector3(-_mouseY, 0, 0);
    }

    public void OnKeyUpdate() => _mouseX += Input.GetAxisRaw("Mouse X") * _speed * Time.deltaTime;
    public void RotateY(Rigidbody rigidbody) => rigidbody.transform.localEulerAngles = new Vector3(0, _mouseX, 0);
}
