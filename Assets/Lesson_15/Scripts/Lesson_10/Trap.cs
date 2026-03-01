using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Transform _parent;
    [SerializeField] private Camera _camera;

    private void OnTriggerEnter(Collider other)
    {
        PushDown(other);

        CreateNewText();
    }

    private void PushDown(Collider other)
    {
        if (other.TryGetComponent(out Rigidbody rigidbody))
            rigidbody.AddForce(Vector3.down, ForceMode.Impulse);
    }

    private void CreateNewText()
    {
        Vector3 newPosition = _camera.WorldToScreenPoint(transform.position);

        Text newText = Instantiate(_scoreText, newPosition, Quaternion.identity, _parent);

        newText.gameObject.SetActive(true);
    }
}
