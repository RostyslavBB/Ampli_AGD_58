using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour, IInteractable
{
    [SerializeField] private VideoPlayer _videoPlayer;

    public void Interact()
    {
        if (_videoPlayer.isPlaying)
            _videoPlayer.Stop();
        else
            _videoPlayer.Play();
    }
}
