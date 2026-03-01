using UnityEngine;

namespace Lesson19
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [SerializeField] private float _damage;

        public void Attack()
        {
            if(!_player.IsDead)
                _player.TakeDamage(_damage);
        }
    }
}