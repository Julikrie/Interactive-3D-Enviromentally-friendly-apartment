using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOnMulti : InteractableObject
{


    public GameObject[] lights;
    public AudioClip audioClip;
    public bool isOn = false;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        foreach (GameObject light in lights)
        {
            light.SetActive(false);
        }
    }
    public override void TriggerInteraction()
    {
        if (isOn)
        {
            audioSource.PlayOneShot(audioClip);
            foreach (GameObject light in lights)
            {
                light.SetActive(false);
            }
        }
        else
        {
            audioSource.PlayOneShot(audioClip);
            foreach (GameObject light in lights)
            {
                light.SetActive(true);
            }
        }
        isOn = !isOn;

    }
}
