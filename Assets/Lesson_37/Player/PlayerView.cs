using TMPro;
using UnityEngine;

namespace Lesson37.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _playerHealthText;

        [SerializeField] private Transform _deathPanel;

        public void UpdatePlayerHealthText(float currentHealth)
        {
            _playerHealthText.text = currentHealth.ToString();
        }

        public void Death()
        {
            _deathPanel.gameObject.SetActive(true);

            Time.timeScale = 0f;
        }

        public void TeleportRandomPosition(Vector3 positionToTeleport)
        {
            transform.position = positionToTeleport;
        }

        public void Move(Vector3 direction, float speed)
        {
            transform.position += speed * Time.deltaTime * direction;
        }
    }
}