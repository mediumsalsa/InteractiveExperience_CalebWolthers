using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private UI_Manager UImanager;

    public enum GameState { MainMenu, Gameplay, Paused, Options, GameOver, GameWin }

    public GameState gameState;


    private void Update()
    {
        switch (gameState)
        { 
            case GameState.MainMenu:    MainMenu();     break;
            case GameState.Gameplay:    Gameplay();     break;
            case GameState.Paused:      Paused();       break;
            case GameState.Options:     Options();      break;
            case GameState.GameOver:    GameOver();     break;
            case GameState.GameWin:     GameWin();      break;
        }
    }


    private void MainMenu()
    {
        UImanager.UI_MainMenu();
    }
    private void Gameplay()
    {
        UImanager.UI_Gameplay();
    }
    private void Paused()
    {
        UImanager.UI_Paused();
    }
    private void Options()
    {
        UImanager.UI_Options();
    }
    private void GameOver()
    {
        UImanager.UI_GameOver();
    }
    private void GameWin()
    {
        UImanager.UI_GameWin();
    }





}
