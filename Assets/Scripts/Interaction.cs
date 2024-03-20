using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject currentObj = null;

    public InteractableObject interactableObjectScript;


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && currentObj != null)
        {
            DoInteraction();
            //Debug.Log("Picked up " + currentObj.name);
        }

    }

    public void DoInteraction()
    {
        if (interactableObjectScript.type == InteractableObject.ObjectType.pickup)
        {
            interactableObjectScript.PickUp();
        }
        if (interactableObjectScript.type == InteractableObject.ObjectType.info)
        {
            interactableObjectScript.Info();
        }
        if (interactableObjectScript.type == InteractableObject.ObjectType.nothing)
        {
            interactableObjectScript.Nothing();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Interactable")
        {
            currentObj = collision.gameObject;
            interactableObjectScript = currentObj.GetComponent<InteractableObject>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Interactable")
        {
            currentObj = null;
            interactableObjectScript = null;
        }
    }

}
