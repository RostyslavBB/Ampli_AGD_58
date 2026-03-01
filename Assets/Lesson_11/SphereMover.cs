using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SphereMover : MonoBehaviour
{
    [SerializeField] private float _forceAmount = 5f;
    [SerializeField] private float _torqueAmount = 5f;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _forceAmount, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddTorque(Vector3.forward * _torqueAmount, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddTorque(Vector3.back * _torqueAmount, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddTorque(Vector3.left * _torqueAmount, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddTorque(Vector3.right * _torqueAmount, ForceMode.Impulse);
        }
    }
}
