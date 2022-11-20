using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public string targetTag;
    public GameObject interactionUI;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == targetTag)
        {
            interactionUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                other.GetComponent<InteractionEvent>().OnInteract.Invoke();
            }
                
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == targetTag)
        {
            interactionUI.SetActive(false);
        }
    }
}
