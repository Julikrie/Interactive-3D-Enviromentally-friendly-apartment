using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundInteraction : InteractableObject
{
    public AudioSource audioSource;

    public AudioClip audioClip;


    void Start()
    {
        audioSource.clip = audioClip;
        audioSource.playOnAwake = false;
    }
    public override void TriggerInteraction()
    {
        if(audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }
}
