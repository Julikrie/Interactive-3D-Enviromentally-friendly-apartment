using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class LightDimmerDown : InteractableObject
{
    public Light[] lights;

    void DecreaseTemperature()
    {
        foreach (Light light in lights)
        {
            light.colorTemperature -= 500;
        }
    }

    public override void TriggerInteraction()
    {
        DecreaseTemperature();
    }
}
