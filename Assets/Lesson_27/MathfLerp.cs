using UnityEngine;

namespace Lesson27
{
    public class MathfLerp : MonoBehaviour
    {
        [SerializeField] private Transform _targetPosition;

        [SerializeField] private float _speed;

        private void Update()
        {
            transform.position = Vector3.Lerp(transform.position,
                _targetPosition.position, Time.deltaTime * _speed);
        }
    }
}