using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class move : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Rigidbody2D rb;
    public GameObject player;
    public GameObject gameover;

    public float speed;
    public float rotateSpeed;
    public float tiltSpeed;
    public float maxSpeed;
    public float maxSpeed1;

    Vector3 direction;

    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }
    
   

    // Update is called once per frame
    void Update()
    {

        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        float angular = (transform.rotation.eulerAngles.z + 90) * Mathf.PI / 180;
        Vector2 direction = new Vector2(Mathf.Cos(angular), Mathf.Sin(angular));
        if ((input.y) == 1)
        {
            rb.velocity += direction* speed * 1;
        }
        if (input.y == -1)
        {
            rb.velocity += direction * speed * -1;
        }
        if (input.y == 0) rb.velocity = Vector2.zero;
        
        if(input.x ==1)
        {
            transform.Rotate(0, 0, -90 * rotateSpeed * Time.deltaTime);
        }

        if (input.x == -1)
        {
            transform.Rotate(0, 0, 90 * rotateSpeed * Time.deltaTime);
        }
        if (rb.velocity.y > maxSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, maxSpeed);
        }
        if (rb.velocity.y < -maxSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, -maxSpeed);
        }
        if (rb.velocity.x > maxSpeed1) rb.velocity = new Vector2(maxSpeed1, rb.velocity.y);
        if (rb.velocity.x < -maxSpeed1) rb.velocity = new Vector2(-maxSpeed1, rb.velocity.y);

        //Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //input = input.normalized;
        //if (input.magnitude > 0.5f)
        //{
        //    rb.velocity = input * speed;
        //    transform.rotation = Quaternion.Lerp(
        //        transform.rotation,
        //        Quaternion.Euler(0, 0, Mathf.Atan2(input.y, input.x) * Mathf.Rad2Deg - 90,
        //        rotateSpeed * Time.deltaTime);
        //}
        //else
        //    rb.velocity = Vector2.zero;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Point")
        {
            Debug.Log("Point");
        }
        else if(collision.tag == "Finished")
        {
            Time.timeScale = 0;
            gameover.SetActive(true);
        }
    }
    public void resetGame()
    {
        SceneManager.LoadScene(0);
    }
}
