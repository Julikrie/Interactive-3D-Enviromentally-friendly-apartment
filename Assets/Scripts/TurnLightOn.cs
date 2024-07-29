using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOn : InteractableObject
{
    public GameObject lightSource;
    public AudioClip audioClip;
    public bool isOn = false;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        lightSource.SetActive(false);
    }
    public override void TriggerInteraction()
    {
        if(isOn)
        {
            audioSource.PlayOneShot(audioClip);
            lightSource.SetActive(false);
        } else
        {
            audioSource.PlayOneShot(audioClip);
            lightSource.SetActive(true);
        }
        isOn = !isOn;
        
    }
}
