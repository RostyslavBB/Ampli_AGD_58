using UnityEngine;

namespace Lesson27
{
    public class MathfPow : MonoBehaviour
    {
        [SerializeField] private float _acceleration = 2f;

        private void Update()
        {
            float speed = Mathf.Pow(Time.time, _acceleration);

            transform.Translate(speed * Time.deltaTime * Vector3.right);
        }
    }
}