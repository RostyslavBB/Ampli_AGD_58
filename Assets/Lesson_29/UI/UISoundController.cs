using UnityEngine;

namespace Lesson29
{
    public class UISoundController : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private SoundData _soundData;

        [SerializeField] private string _clickSoundName;

        private readonly SFXManager _sfxManager = new();

        public void PlaySound()
        { 
            _sfxManager.Play(_audioSource, _soundData, _clickSoundName);
        }
    }
}