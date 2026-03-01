using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    private const float LIVE_DURATION = 2f;
    private const float SPEED = 0.5f;

    void Update()
    {
        transform.position += Vector3.up * SPEED;

        Destroy(gameObject, LIVE_DURATION);
    }
}
