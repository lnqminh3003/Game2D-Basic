using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movexanhla : MonoBehaviour
{
    public float speed;
    public Rigidbody2D r2;
    public float maxspeed;
    public float maxspeedX;
    public GameObject gameover;
    public float rotateSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 input = new Vector2(Input.GetAxisRaw("Fire1"), Input.GetAxisRaw("Fire2"));
        float ang = (transform.rotation.eulerAngles.z + 90) * Mathf.PI / 180;
        Vector2 direction = new Vector2(Mathf.Cos(ang), Mathf.Sin(ang));
        if(Mathf.Abs(input.y) > 0f)
        {
            r2.velocity += direction * speed * input.y;
        }
        if(Mathf.Abs(input.x) >0f)
        {
            transform.Rotate(0, 0, -90 * rotateSpeed *input.x*Time.deltaTime);
        }
        if (r2.velocity.y > maxspeed) r2.velocity = new Vector2(r2.velocity.x, maxspeed);
        if (r2.velocity.y < -maxspeed) r2.velocity = new Vector2(r2.velocity.x, -maxspeed);
        if (r2.velocity.x > maxspeed) r2.velocity = new Vector2(maxspeed, r2.velocity.y);
        if (r2.velocity.x < -maxspeed) r2.velocity = new Vector2(-maxspeed, r2.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        gameover.SetActive(true);
    }
    public void resetgame()
    {
        SceneManager.LoadScene(0);
    }
}
