using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Progress;

public class UI_Manager : MonoBehaviour
{

    public GameObject oMainMenu;
    public GameObject oGameplay;
    public GameObject oPaused;
    public GameObject oOptions;
    public GameObject oGameOver;
    public GameObject oGameWin;


    public void UI_MainMenu()
    {
        SetAllFalse();
        oMainMenu.SetActive(true);
    }
    public void UI_Gameplay()
    {
        SetAllFalse();
        oGameplay.SetActive(true);
    }
    public void UI_Paused()
    {
        SetAllFalse();
        oPaused.SetActive(true);
    }
    public void UI_Options()
    {
        SetAllFalse();
        oOptions.SetActive(true);
    }
    public void UI_GameOver()
    {
        SetAllFalse();
        oGameOver.SetActive(true);
    }
    public void UI_GameWin()
    {
        SetAllFalse();
        oGameWin.SetActive(true);
    }

    public void SetAllFalse()
    {
        oMainMenu.SetActive(false);
        oGameplay.SetActive(false);
        oPaused.SetActive(false);
        oOptions.SetActive(false);
        oGameOver.SetActive(false);
        oGameWin.SetActive(false);
    }


}
