using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [field: SerializeField] public Rigidbody BallRigidbody { get; private set; }
}
