using UnityEngine;

namespace Lesson20
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [SerializeField] private float _damage = 20;

        public void Attack()
        {
            _player.TakeDamage(_damage);
        }
    }
}