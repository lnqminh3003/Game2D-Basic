using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f,10f)][SerializeField] float gameState;
    [SerializeField] int scorePerBlockDestroy;
    [SerializeField] TextMeshProUGUI textScore;
    [SerializeField] int score;
    [SerializeField] bool autoPlay;


    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
   
    private void Start()
    {
        textScore.text = score.ToString();
    }
    void Update()
    {
        Time.timeScale = gameState;
    }
    public void countScore()
    {
        score += scorePerBlockDestroy;
        textScore.text = score.ToString();
    }
    public void resetGame()
    {
        Destroy(gameObject);
    }
    public bool AutoPlay()
    {
        return autoPlay;
    }
}
