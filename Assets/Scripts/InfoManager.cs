using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoManager : MonoBehaviour
{

    public TextMeshProUGUI textInfo;

    private InteractableObject interactableObject;

    public void StartInfo()
    {

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindAnyObjectByType<LevelManager>().LoadScene("Resume");
        }
    }



}
