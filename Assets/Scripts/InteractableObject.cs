using TMPro;
using UnityEngine;
using System.Collections;

public class InteractableObject : MonoBehaviour
{
    public enum ObjectType { nothing, pickup, info, dialogue }

    public ObjectType type;

    public string objText;

    public Dialogue dialogue;
 

    public void PickUp()
    {
        Debug.Log("Pick Up Item");

        Destroy(gameObject);
    }

    public void Info()
    {
        
    }

    public void Dialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void Nothing()
    {

    }
}
