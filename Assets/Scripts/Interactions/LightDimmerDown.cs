using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class LightDimmerDown : InteractableObject
{
    public AudioClip audioClip;
    public Light[] lights;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void DecreaseTemperature()
    {
        foreach (Light light in lights)
        {
            audioSource.PlayOneShot(audioClip);
            light.colorTemperature -= 500;
        }
    }

    public override void TriggerInteraction()
    {
        DecreaseTemperature();
    }
}
