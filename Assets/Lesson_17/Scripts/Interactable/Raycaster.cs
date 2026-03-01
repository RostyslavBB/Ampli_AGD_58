using UnityEngine;

public class Raycaster : MonoBehaviour
{
    [SerializeField] private LayerMask _targetLayers;

    [SerializeField] private float _rayLength = 3f;

    private void Update()
    {
        Debug.Log(name);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, forward, out RaycastHit raycastHit, _rayLength, _targetLayers))
            {
                if (raycastHit.transform.TryGetComponent(out IInteractable interactable))
                {
                    interactable.Interact();

                    Debug.Log("It`s iteractable :) ");
                }
                else
                {
                    Debug.Log("Join script with IInteractable interface to this object");
                }
            }
        }
    }
}