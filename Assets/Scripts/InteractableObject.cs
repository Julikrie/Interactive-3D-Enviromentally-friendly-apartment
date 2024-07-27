using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class InteractableObject : MonoBehaviour
{
    public string commandText;

    public abstract void TriggerInteraction();
}
