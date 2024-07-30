using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDimmerUp : InteractableObject
{
    public AudioClip audioClip;
    public Light[] lights;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void IncreaseTemperature()
    {
        foreach (Light light in lights)
        {
            audioSource.PlayOneShot(audioClip);
            light.colorTemperature += 500;
        }
    }
    public override void TriggerInteraction()
    {
        IncreaseTemperature();
    }
}
