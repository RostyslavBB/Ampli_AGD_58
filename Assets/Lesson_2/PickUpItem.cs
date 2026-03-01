using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] private string _itemName;

    public void OnPickUp()
    {
        Debug.Log($"Picked up: {_itemName}");
        Destroy(gameObject);
    }
}
