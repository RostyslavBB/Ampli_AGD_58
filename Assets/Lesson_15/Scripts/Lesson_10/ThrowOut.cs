using UnityEngine;
using UnityEngine.UI;

public class ThrowOut : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Slider _throwForceSlider;

    [SerializeField] private float _speedForceAdding = 100f;
    [SerializeField] private float _speedForceUpAdding = 5f;
    [SerializeField] private float _forwardForce = 0f;
    [SerializeField] private float _upForce = 3f;

    private void Awake()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ChangeForce();
        }

        if (Input.GetMouseButtonUp(0))
        {
            ThrowBall();

            ResetForce();
        }
    }

    private void ResetForce()
    {
        _throwForceSlider.value = 0;
        _forwardForce = 0;
        _upForce = 0;
    }

    private void ChangeForce()
    {
        if (_forwardForce < _speedForceAdding)
        {
            _forwardForce += Time.deltaTime * _speedForceAdding;
        }
        if (_upForce < _speedForceUpAdding)
        {
            _upForce += Time.deltaTime * _speedForceUpAdding;
        }

        _throwForceSlider.value = _forwardForce;
    }

    private void ThrowBall()
    {
        Ball newBall = Instantiate(_ball, transform.position, transform.rotation);

        Vector3 direction = transform.forward * _forwardForce;

        direction.y *= _upForce;

        newBall.BallRigidbody.AddForce(direction);
    }
}
