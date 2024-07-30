using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletDualFlush : InteractableObject
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public override void TriggerInteraction()
    {
        audioSource.PlayOneShot(audioClip);
    }

    // Start is called before the first frame update

}
