using TMPro;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public enum ObjectType { nothing, pickup, info, dialogue }

    public ObjectType type;

    public Canvas playerCanvas;
    public TextMeshProUGUI playerText;
    public string objText;

    public Dialogue dialogue;

    public void PickUp()
    {
        Debug.Log("Pick Up Item");

        Destroy(gameObject);
    }

    public void Info()
    {
        playerCanvas.enabled = true;
        playerText.text = objText;
        Debug.Log("Info object");
    }

    public void Dialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void Nothing()
    {

    }
}
