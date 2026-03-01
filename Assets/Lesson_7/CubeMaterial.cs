using UnityEngine;

[RequireComponent(typeof(Material))]
public class CubeMaterial : MonoBehaviour
{
    [SerializeField] private Material _objectMaterial;  

    public Material ObjectMaterial =>_objectMaterial;
}
