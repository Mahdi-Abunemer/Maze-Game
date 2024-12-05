using UnityEngine;

public class LoopingAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.loop = true; // Set the loop property
            audioSource.Play();      // Play the audio
        }
    }
}
