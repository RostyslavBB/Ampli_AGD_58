using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private SphereMover _sphereMover;

    [SerializeField] private Vector3 _cameraPosition;

    private void LateUpdate()
    {
        transform.position = _sphereMover.transform.position + _cameraPosition;
    }
}
