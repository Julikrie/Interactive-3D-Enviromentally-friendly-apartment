using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GazeController : MonoBehaviour
{
    public float maxDistance = 5;

    public TextMeshProUGUI contextLabel;

    public GameObject contextLabelContainer;

    private InteractableObject currentGazeObject;

    private RectTransform contextLabelTransform;


    // Start is called before the first frame update
    void Start()
    {
        contextLabelTransform = contextLabel.GetComponent<RectTransform>();
    }

    private void FixedUpdate()
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 origin = Camera.main.transform.position;
        RaycastHit hit;

        if(Physics.Raycast(origin, forward, out hit, maxDistance) && hit.collider.gameObject.GetComponent<InteractableObject>() != null)
        {
            Debug.DrawRay(origin, forward * hit.distance, Color.green);

            contextLabelContainer.SetActive(true);
            currentGazeObject = hit.collider.gameObject.GetComponent<InteractableObject>();
            contextLabel.text = currentGazeObject.commandText;

            LayoutRebuilder.ForceRebuildLayoutImmediate(contextLabelTransform);
        }
        else
        {
            Debug.DrawRay(origin, forward * maxDistance, Color.red);

            contextLabelContainer.SetActive(false);
            contextLabel.text = "";
            currentGazeObject = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && currentGazeObject != null)
        {
            currentGazeObject.TriggerInteraction();
        }
    }
}
