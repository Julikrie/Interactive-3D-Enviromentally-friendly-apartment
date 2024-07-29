using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : InteractableObject
{
    public Animator animator;
    private bool isOpen = false;

    public override void TriggerInteraction()
    {
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
    }
}
