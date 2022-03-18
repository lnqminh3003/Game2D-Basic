using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour
{
    TextMeshProUGUI textHealthPlayer;
    [SerializeField] int health;
    private void Start()
    {
        textHealthPlayer = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textHealthPlayer.text = health.ToString();
    }
    public int GetHealthPlayer()
    {
        return health;
    }
    public void DecreaseHealth()
    {
        health -= 20;
        if(health <=0 )
        {
            FindObjectOfType<LevelController>().ActiveYouLoseCanvas();
        }
    }

   
}
