using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public UI_Manager UImanager;

    private LevelManager _levelManager;

    private PlayerController _playerController;
    public GameObject _player;

    public GameObject spawnPoint;

    public enum GameState { MainMenu, Gameplay, Paused, Options, GameOver, GameWin, Dialogue }
    public GameState gameState;

    public void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        gameState = GameState.MainMenu;

        _levelManager = FindObjectOfType<LevelManager>();

        _playerController = FindObjectOfType<PlayerController>();

    }

    public void PlayerSpawn()
    {
        spawnPoint = GameObject.FindWithTag("SpawnPoint");

        _player.transform.position = spawnPoint.transform.position;
    }


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
            case GameState.Dialogue:    Dialogue();     break;
        }
    }


    public void MainMenu()
    {
        Cursor.visible = true;

        _playerController.enabled = false;
        _player.GetComponent<SpriteRenderer>().enabled = false;

        UImanager.UI_MainMenu();
    }
    public void Gameplay()
    {
        _playerController.enabled = true;
        _player.GetComponent<SpriteRenderer>().enabled = true;

        _player.SetActive(true);

        UImanager.UI_Gameplay();
    }
    public void Paused()
    {
        _playerController.enabled = false;
        UImanager.UI_Paused();
    }
    public void Options()
    {
        _playerController.enabled = false;
        UImanager.UI_Options();
    }
    public void GameOver()
    {
        UImanager.UI_GameOver();
        _playerController.enabled = false;
        _player.GetComponent<SpriteRenderer>().enabled = false;
    }
    public void GameWin()
    {
        UImanager.UI_GameWin();
        _playerController.enabled = false;
        _player.GetComponent<SpriteRenderer>().enabled = false;
    }
    public void Dialogue()
    {
        UImanager.UI_Dialogue();
        _playerController.enabled = false;
        _player.GetComponent<SpriteRenderer>().enabled = true ;
    }





}
