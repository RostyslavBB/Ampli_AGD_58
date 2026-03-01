using UnityEngine;

public class MathemeticTest : MonoBehaviour
{
    [SerializeField] private Transform _targetPosition;

    private void Update()
    {
        Vector3 direction = _targetPosition.position - transform.position;

        Quaternion lookRotation = Quaternion.LookRotation(direction);

        transform.rotation = lookRotation;
    }
}
