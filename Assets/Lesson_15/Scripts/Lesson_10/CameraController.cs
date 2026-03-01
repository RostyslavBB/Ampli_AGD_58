using UnityEngine;

[RequireComponent (typeof(Camera))]
public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private const float OFFSETY = 1.2f;
    
    private void LateUpdate()
    {
        Ray mouseRay = _camera.ScreenPointToRay(Input.mousePosition);

        Vector3 targetMousePosition = new(mouseRay.direction.x, mouseRay.direction.y * OFFSETY, mouseRay.direction.z);

        transform.LookAt(targetMousePosition);
    }
}
