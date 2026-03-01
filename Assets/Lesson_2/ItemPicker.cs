using TMPro;
using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    [SerializeField] private float _pickupDistance = 3f;
    [SerializeField] private LayerMask _pickupLayerMask;
    [SerializeField] private TMP_Text _itemCountText;

    private Camera _camera;
    private int _itemCount = 0;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryPickUp();
        }
    }

    private void TryPickUp()
    {
        Ray ray = new Ray(_camera.transform.position, _camera.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, _pickupDistance, _pickupLayerMask))
        {
            if (hit.collider.TryGetComponent<PickUpItem>(out var item))
            {
                item.OnPickUp();
                _itemCount++;
                _itemCountText.text = _itemCount.ToString();
            }
        }
    }
}
