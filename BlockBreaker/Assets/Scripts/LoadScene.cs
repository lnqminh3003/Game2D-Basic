using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    GameStatus gameStatus;
    private void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
    }
    public void loadscene()
    {
        Scene sceneCurrent = SceneManager.GetActiveScene();
        int indexCurrentScene = sceneCurrent.buildIndex;
        if(sceneCurrent.name == "PlayAgain")
        {
            SceneManager.LoadScene(0);
            gameStatus.resetGame();
            return;
        }
        SceneManager.LoadScene(indexCurrentScene + 1);

    }
    public void quitGame()
    {
        Application.Quit();
    }
}
