using UnityEngine;

namespace Lesson27
{
    public class MathfClamp : MonoBehaviour
    {
        [SerializeField] private float _minYvalue = -3f;
        [SerializeField] private float _maxYvalue = 3f;

        private void Update()
        {
            float y = Mathf.Clamp(transform.position.y, _minYvalue, _maxYvalue);

            transform.position = new(transform.position.x, y, transform.position.z);
        }
    }
}