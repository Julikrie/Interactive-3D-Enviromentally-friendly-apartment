using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticLamps : MonoBehaviour
{
    public GameObject[] lights;
    public AudioClip audioClip;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        foreach (GameObject light in lights)
        {
            light.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        foreach (GameObject light in lights)
        {
            if (light != null)
            {
                audioSource.PlayOneShot(audioClip);
                light.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Deactivate all lights when the trigger is exited
        foreach (GameObject light in lights)
        {
            if (light != null)
            {
                audioSource.PlayOneShot(audioClip);
                light.SetActive(false);
            }
        }
    }
}

