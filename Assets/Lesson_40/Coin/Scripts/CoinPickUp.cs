using UnityEngine;
using Lesson37.Player;

namespace Lesson40
{
    public class CoinPickUp : MonoBehaviour
    {
        [SerializeField] private float _coinValue = 5f;

        [SerializeField] private UiUpdater _updater;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.TryGetComponent(out Player player))
            {
                _updater.UpdateScore(_coinValue);
                Destroy(gameObject);
            }
        }
    }
}