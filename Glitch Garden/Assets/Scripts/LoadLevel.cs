using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void ButtonPlayAgain()
    {
        Scene currenScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currenScene.name);
    }
}
