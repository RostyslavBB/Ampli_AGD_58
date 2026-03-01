using System;
using System.Collections;
using UnityEngine;

namespace Lesson19
{
    public class Player : MonoBehaviour
    {
        public Action OnTakeDamage;
        public Action OnDeath;

        [SerializeField] private MeshRenderer _playerView;

        [field: SerializeField] public float CurrentHp { get; private set; } = 100;
        public bool IsDead { get; private set; }

        public void TakeDamage(float damage)
        {
            if (CurrentHp <= damage)
            {
                StartCoroutine(Death());

                return;
            }

            CurrentHp -= damage;

            OnTakeDamage.Invoke();
        }

        private IEnumerator Death()
        {
            IsDead = true;

            OnDeath.Invoke();

            _playerView.enabled = false;

            yield return new WaitForSeconds(5f);

            Destroy(gameObject);
        }
    }
}