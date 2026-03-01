using UnityEngine;

namespace Lesson29
{
    public class SFXManager
    {
        public void Play(AudioSource audioSource, SoundData soundData, string soundName)
        {
            foreach (Sound sound in soundData.Sounds)
            {
                if(sound.Name == soundName)
                {
                    audioSource.clip = sound.Clip;
                    audioSource.volume = sound.Volume;    

                    audioSource.Play();

                    return;
                }
            }

            Debug.LogError($"Sound with name {soundName} is not found");
        }
    }
}