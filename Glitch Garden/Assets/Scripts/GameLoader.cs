using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(loadSceneStart());
    }
    IEnumerator loadSceneStart()
    {

        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Start");
    }
}
