using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    [SerializeField] private CubeMaterial[] _cubeMaterials;

    [SerializeField] protected Color _objectsColor;

    private void Start()
    {
        foreach (CubeMaterial cubeMaterial in _cubeMaterials)
        {
            cubeMaterial.ObjectMaterial.color = _objectsColor;
        }
    }
}
