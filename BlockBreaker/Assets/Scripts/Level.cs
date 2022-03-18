using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int countBlockAppear;
    LoadScene loadScene;

    private void Start()
    {
        loadScene = FindObjectOfType<LoadScene>();
    }
  
    public void deleteCountToPassNewLevel()
    { 
        countBlockAppear--;
        if(countBlockAppear == 0 )
        {
            loadScene.loadscene();
        }
    }
    public void countBlock()
    {
        countBlockAppear++;
    }
}
