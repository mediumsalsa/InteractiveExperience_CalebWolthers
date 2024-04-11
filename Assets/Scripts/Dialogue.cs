using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue
{

    public string name;

    [TextArea(3, 10)]
    public string[] dialogues;

    [TextArea(3, 10)]
    public string[] rewardDialogues;

    public GameObject requiredItem;
    public GameObject rewardItem;

}
