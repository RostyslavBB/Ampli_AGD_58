using UnityEngine;

public class TestRay : MonoBehaviour
{
    [SerializeField] private float _rayDistance = 5f;

    private void Update()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position, transform.forward * _rayDistance);

        foreach (RaycastHit hit in hits )
        {
            Debug.Log(hit.collider);
        }
    }
}
