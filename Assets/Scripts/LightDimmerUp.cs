using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDimmerUp : InteractableObject
{
    public Light[] lights;
    
    void IncreaseTemperature()
    {
        foreach (Light light in lights)
        {
            light.colorTemperature += 500;
        }
    }
    public override void TriggerInteraction()
    {
        IncreaseTemperature();
    }
}
