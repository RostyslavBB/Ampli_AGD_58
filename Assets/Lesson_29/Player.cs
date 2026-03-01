using UnityEngine;

namespace Lesson29
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private SoundData _soundData;

        [SerializeField] private string _jumpSound;
        [SerializeField] private string _landSound;

        private readonly SFXManager _sfxManager = new();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _sfxManager.Play(_audioSource, _soundData, _jumpSound);
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                _sfxManager.Play(_audioSource, _soundData, _landSound);
            }
        }
    }
}