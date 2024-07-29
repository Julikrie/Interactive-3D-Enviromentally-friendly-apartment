using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SolarDisplay : MonoBehaviour
{
    private TextMeshProUGUI text; 
    private float minIntake = 1.1f;    
    private float maxIntake = 1.7f;
    public float updateInterval = 1f; 

    private float currentIntake;
    private float timer;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        currentIntake = Random.Range(minIntake, maxIntake);
        text.text = $"{currentIntake.ToString("F1")} KW/H";
        timer = updateInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            UpdateIntake();
            timer = updateInterval;
        }
    }

    void UpdateIntake()
    {
        currentIntake = Random.Range(minIntake, maxIntake);
        text.text = $"{currentIntake.ToString("F1")} KW/H";
    }
}