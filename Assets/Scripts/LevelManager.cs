using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public GameManager gameManager;

    public GameObject _player;

    public void LoadScene(string levelName)
    {
        SceneManager.sceneLoaded += OnSceneLoaded;

        if (levelName != null)
        { 
            if (levelName.StartsWith("MainMenu"))
            {
                SceneManager.LoadScene(levelName);
                gameManager.gameState = GameManager.GameState.MainMenu;
            }
            else if (levelName.StartsWith("GamePlayGrass"))
            {
                SceneManager.LoadScene(levelName);
                gameManager.gameState = GameManager.GameState.Gameplay;
            }
            else if (levelName.StartsWith("GamePlaySand"))
            {
                SceneManager.LoadScene(levelName);
                gameManager.gameState = GameManager.GameState.Gameplay;
            }
            else if (levelName.StartsWith("GameWin"))
            {
                SceneManager.LoadScene(levelName);
                gameManager.gameState = GameManager.GameState.GameWin;
            }
        }

    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        gameManager.PlayerSpawn();
    }


}
