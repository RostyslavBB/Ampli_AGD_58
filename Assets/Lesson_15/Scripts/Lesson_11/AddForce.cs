using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float Speed = 20;
    public float restartTime = 1f;
    private Rigidbody Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();

        Rigidbody.AddTorque(new Vector3(0, 1, 0) * Speed, ForceMode.Force);
    }

    private void OnMouseDown()
    {
        Rigidbody.isKinematic = true;

        Invoke("RestartGravity", restartTime);
    }

    private void RestartGravity()
    {
        Rigidbody.isKinematic = false;
    }
}
