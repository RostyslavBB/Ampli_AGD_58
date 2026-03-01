using UnityEngine;

public class ExhaustFan : MonoBehaviour, IInteractable
{
    [SerializeField] private AudioSource _exhaustFanSound;

    public void Interact()
    {
        if(_exhaustFanSound.isPlaying)
            _exhaustFanSound.Stop();
        else
            _exhaustFanSound.Play();
    }
}
