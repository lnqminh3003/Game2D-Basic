using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush;
    [SerializeField] float yPush;
    [SerializeField] AudioClip []ballSound;
    [SerializeField]float randomFactor;
    bool checkStarted;
    AudioSource sound;
    Rigidbody2D rd;
    void Start()
    {
        checkStarted = false;
        sound = GetComponent<AudioSource>();
        rd = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if (checkStarted == false)
        {
            startGame();
            launchTheBall();
        }
    }

    private void launchTheBall()
    {
            if (Input.GetMouseButtonDown(0))
            {
                checkStarted = true;
                rd.velocity = new Vector2(xPush, yPush);
            }
        
    }
    private void startGame()
    {
        Vector2 tmp = new Vector2(paddle1.transform.position.x, transform.position.y);
        transform.position = tmp;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moreVelocity();
        ballSoundSFX(collision);

    }

    private void moreVelocity()
    {
        Vector2 moreVelocity = new Vector2
            (UnityEngine.Random.Range(-0.5f, randomFactor),
            UnityEngine.Random.Range(-0.5f, randomFactor));
        if (checkStarted)
        {
            rd.velocity += moreVelocity;
        }
    }

    private void ballSoundSFX(Collision2D collision)
    {
        if (collision.gameObject.tag == "paddle")
        {
            if (checkStarted)
            {
                sound.PlayOneShot(ballSound[0]);
            }
        }
        else if (collision.gameObject.tag == "Breakable")
        {
            sound.PlayOneShot(ballSound[UnityEngine.Random.Range(1, 3)]);
        }
        else if (collision.gameObject.tag == "Unbreakable")
        {
            sound.PlayOneShot(ballSound[3]);
        }
    }
}
