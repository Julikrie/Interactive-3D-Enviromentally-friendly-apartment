using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : InteractableObject
{
    
    private bool isOpen = false;

    public override void TriggerInteraction()
    {
        isOpen = !isOpen;
        Debug.Log($"Ich bin gerade offen: {isOpen}");
        GetComponent<Animator>().SetBool("isOpen", isOpen);
    }
}
