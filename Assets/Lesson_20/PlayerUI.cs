using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson20
{
    public class PlayerUI : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [SerializeField] private TMP_Text _playerHealthText; 

        [SerializeField] private Slider _playerHealthSlider; 

        private void OnEnable()
        {
            _player.OnTakeDamage += UpdatePlayerHealth;
            _player.OnDeath += Death;
        }

        private void Awake()
        {
            UpdatePlayerHealthText();
            UpdatePlayerHealthSlider();
        }

        private void UpdatePlayerHealth(float damage)
        {
            StartCoroutine(UpdatePlayerUI(damage));
        }

        private void Death()
        {
            UpdatePlayerHealthText();
            UpdatePlayerHealthSlider();
        }

        private void UpdatePlayerHealthText()
        {
            _playerHealthText.text = ((int)_player.CurrentHealth).ToString();
        }

        private void UpdatePlayerHealthSlider()
        {
            _playerHealthSlider.value = _player.CurrentHealth;
        }

        private IEnumerator UpdatePlayerUI(float damage)
        {
            float targetHealth = _player.CurrentHealth - damage;

            while (_player.CurrentHealth > targetHealth)
            {
                _player.CurrentHealth -= damage * Time.deltaTime;

                if (_player.CurrentHealth <= targetHealth)
                    _player.CurrentHealth = targetHealth;

                UpdatePlayerHealthText();
                UpdatePlayerHealthSlider();

                yield return null;
            }
        }

        private void OnDisable()
        {
            _player.OnTakeDamage -= UpdatePlayerHealth;
            _player.OnDeath -= Death;
        }
    }
}