using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseControl : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
 
        SceneManager.LoadScene("PlayAgain");
    }
}
