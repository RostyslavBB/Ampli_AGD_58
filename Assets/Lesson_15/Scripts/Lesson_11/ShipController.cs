using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public ParticleSystem LeftFire;
    public ParticleSystem RightFire;

    public float Speed = 5f;
    public float LeftSpeed = 5f;
    public float RightSpeed = 5f;

    private Vector3 _startRotation;

    private void Start()
    {
        _startRotation = transform.rotation.eulerAngles;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            Rigidbody.AddForce(Vector3.up * Speed, ForceMode.Force);
            Rigidbody.AddTorque(Vector3.back * LeftSpeed, ForceMode.Force);

            if (!LeftFire.isPlaying)
            {
                LeftFire.Play();
                RightFire.Stop();
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            Rigidbody.AddForce(Vector3.up * Speed, ForceMode.Force);
            Rigidbody.AddTorque(Vector3.forward * RightSpeed, ForceMode.Force);

            if (!RightFire.isPlaying)
            {
                RightFire.Play();
                LeftFire.Stop();
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            Rigidbody.AddForce(Vector3.up * Speed, ForceMode.Force);
            Rigidbody.angularVelocity = Vector3.zero;
            transform.rotation = Quaternion.Euler(_startRotation);

            if (!RightFire.isPlaying)
            {
                RightFire.Play();
            }

            if (!LeftFire.isPlaying)
            {
                LeftFire.Play();
            }
        }

    }
}
