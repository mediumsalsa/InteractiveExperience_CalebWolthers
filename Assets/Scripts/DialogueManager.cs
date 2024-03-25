using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{


    public TextMeshProUGUI textName;
    public TextMeshProUGUI textDialogue;

    private Queue<string> dialogueQueue = new Queue<string>();

    public void Start()
    {
        dialogueQueue = new Queue<string>();
    }

    public void StartDialogue()
    {

    }

}