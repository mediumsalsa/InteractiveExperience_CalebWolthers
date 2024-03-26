using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI textName;
    public TextMeshProUGUI textDialogue;

    private Queue<string> dialogues = new Queue<string>();

    public void Start()
    {
        dialogues = new Queue<string>();
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        FindAnyObjectByType<LevelManager>().LoadScene("Dialogue");

        textName.text = dialogue.name;
        Debug.Log("Starting conversation with " + dialogue.name);

        dialogues.Clear();

        foreach (string sentence in dialogue.dialogues)
        {
            dialogues.Enqueue(sentence);    
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        if (dialogues.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = dialogues.Dequeue();

        textDialogue.text = sentence;
        Debug.Log(sentence);
    }

    public void EndDialogue()
    {
        Debug.Log("End of conversation ");
        FindAnyObjectByType<LevelManager>().LoadScene("Resume");
    }


}