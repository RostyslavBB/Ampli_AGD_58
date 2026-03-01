using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Ball;
    public float Speed = 1f;
    public Vector3 Direction;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Time.timeScale = 0.1f;
        GameObject newBall = Instantiate(Ball, transform.position, Quaternion.identity);
        newBall.GetComponent<Rigidbody>().AddForce(Direction * Speed, ForceMode.Impulse);
    }
}
