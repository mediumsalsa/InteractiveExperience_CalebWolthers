using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractableObject : MonoBehaviour
{

    public enum ObjectType { nothing, pickup, info }

    public Canvas playerCanvas;
    public TextMeshProUGUI playerText;
    public string objText;

    public ObjectType type;


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

    public void Nothing()
    {

    }




}
