using TMPro;
using UnityEngine;

namespace Lesson19
{
    public class PlayerUi : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [SerializeField] private TMP_Text _playerHpText;

        [SerializeField] private string _deathMesseage;

        private void Start()
        {
            UpdatePlayerUiHp();
        }

        private void OnEnable()
        {
            _player.OnTakeDamage += UpdatePlayerUiHp;
            _player.OnDeath += PlayerDeath;
        }

        private void OnDisable()
        {
            _player.OnTakeDamage -= UpdatePlayerUiHp;
        }

        private void UpdatePlayerUiHp()
        {
            _playerHpText.text = _player.CurrentHp.ToString();
        }

        private void PlayerDeath()
        {
            _playerHpText.text = _deathMesseage;
        }
    }
}