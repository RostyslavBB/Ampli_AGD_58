using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocity : MonoBehaviour
{
    public Rigidbody _myRigidbody;

    public float Speed = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _myRigidbody.velocity += Vector3.left * Speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _myRigidbody.velocity += Vector3.right * Speed;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _myRigidbody.velocity += Vector3.up * Speed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _myRigidbody.velocity += Vector3.down * Speed;
        }
    }
}
