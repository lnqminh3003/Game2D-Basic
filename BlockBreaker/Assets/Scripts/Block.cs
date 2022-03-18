using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Block : MonoBehaviour
{
    
    Level level;
    GameStatus gameStatus;
    [SerializeField] GameObject blockSparkVFX;
    [SerializeField] int timesHit = 0;
    [SerializeField] Sprite[] ballSprite;
    

    private void Start()
    {
       
        level = FindObjectOfType<Level>();
        gameStatus = FindObjectOfType<GameStatus>();
        if (tag == "Breakable")
        {
            level.countBlock();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        handleHit();
    }

    private void handleHit()
    {
        if (tag == "Breakable")
        {
            int maxHit = ballSprite.Length + 1;
            timesHit++;
            showNextSprite();
            if (timesHit == maxHit)
            {
                destroyBlock();
            }

        }
    }

    private void showNextSprite()
    {
        if (timesHit <= ballSprite.Length)
        {
            GetComponent<SpriteRenderer>().sprite = ballSprite[timesHit - 1];
        }
    }

    private void destroyBlock()
    {
        gameStatus.countScore();
        sparkVFX();
        Destroy(gameObject);
        level.deleteCountToPassNewLevel();
    }

    private void sparkVFX()
    {
        GameObject sparks = Instantiate(blockSparkVFX, transform.position, transform.rotation);
        Destroy(sparks, 1f);
    }

    
    
   
}
