using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMaterialInteraction : InteractableObject
{
    public Material[] materials;

    public MeshRenderer[] renderers;

    private int currentIndex;


    private void Start()
    {
        ChangeMaterial(0);
    }
    public override void TriggerInteraction()
    {
        ChangeMaterial(currentIndex + 1);
    }

    private void ChangeMaterial(int newMaterialIndex)
    {
        currentIndex = (newMaterialIndex >= materials.Length) ? 0 : newMaterialIndex;

        for (int i = 0; i < renderers.Length; i++)
        {
            renderers[i].material = materials[currentIndex];
        }
    }
}
