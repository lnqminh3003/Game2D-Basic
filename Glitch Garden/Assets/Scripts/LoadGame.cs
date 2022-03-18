using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadGame : MonoBehaviour
{
    public void LoadToGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Start");
    }
    public void LoadStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void LoadOption()
    {
        SceneManager.LoadScene("Option");
    }
    public void DefaultButton()
    {
        PlayerPresController.SetVolumeKey(0.8f);
        PlayerPresController.SetDifficulty(0f);
        FindObjectOfType<DifficultController>().SetDefaultDiff();
        FindObjectOfType<VolumeController>().SetDefaultSlider(0.8f);
    }
}
