using UnityEngine;

namespace Lesson19
{
    public class PlayerEffects : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [SerializeField] private ParticleSystem _deathParticle;

        private void OnEnable()
        {
            _player.OnDeath += ActivateDeathEffect;
        }

        private void OnDisable()
        {
            _player.OnDeath -= ActivateDeathEffect;
        }

        private void ActivateDeathEffect()
        {
            _deathParticle.Play();
        }
    }
}