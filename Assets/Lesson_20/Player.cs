using System;
using UnityEngine;

namespace Lesson20
{
    public class Player : MonoBehaviour
    {
        public event Action<float> OnTakeDamage;

        public event Action OnDeath;

        public float CurrentHealth { get; set; } = 100;

        public void TakeDamage(float damage)
        {
            if (CurrentHealth < damage)
            {
                CurrentHealth = 0;

                Death();

                return;
            }

            OnTakeDamage?.Invoke(damage);
        }

        private void Death()
        {
            OnDeath?.Invoke();

            Debug.Log("Player is dead");
        }
    }
}