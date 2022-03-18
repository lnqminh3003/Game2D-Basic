using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    private void Awake()
    {
        Scene currenScene = SceneManager.GetActiveScene();
        int countMusicObject = FindObjectsOfType<Music>().Length;
        if (countMusicObject == 2)
        {
            Destroy(gameObject);
           
        }
        else if(currenScene.name == "Start")
        {
            DontDestroyOnLoad(gameObject);
        }  
        
    }
   

}
