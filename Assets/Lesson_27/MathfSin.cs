using UnityEngine;

namespace Lesson27
{
    public class MathfSin : MonoBehaviour
    {
        [SerializeField] private float _amplitude = 1f;
        [SerializeField] private float _frequency = 2f;

        private void Update()
        {
            float x = Mathf.Sin(Time.time * _frequency) * _amplitude;
            float y = Mathf.Sin(Time.time * _frequency) * _amplitude;

            transform.position = new(x, y, 0);
        }
    }
}