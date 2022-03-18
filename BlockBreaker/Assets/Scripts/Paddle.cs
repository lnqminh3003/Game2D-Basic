using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidth = 0f;
    [SerializeField] float minField = 1f;
    [SerializeField] float maxField = 15f;



    GameStatus gameStatus;
    Ball ball;
    void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
        ball = FindObjectOfType<Ball>();

    }

    void Update()
    {
        Vector2 tmp = new Vector2(getPosX(), transform.position.y);
        transform.position = tmp;
    }
    private float getPosX()
    {
        if(gameStatus.AutoPlay())
        {
            return ball.transform.position.x;
        }
        else
        {
            float mousePositionInUnit = Input.mousePosition.x / Screen.width * screenWidth;
            float mouseInRange = Mathf.Clamp(mousePositionInUnit, minField, maxField);
            return mouseInRange;
        }
    }
}
;