using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
  
    float currenSpeed;
    Plant plant;
    [SerializeField] float damage;


    private void Update()
    {        
        transform.Translate(Vector2.left * currenSpeed * Time.deltaTime);
        UpdateCurrenState();
    }

    private void UpdateCurrenState()
    {
        if(!plant)
        {
            GetComponent<Animator>().SetBool("IsAttacking",false);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        speed += PlayerPresController.GetDifficultKey();
        currenSpeed = speed;
    }

    public void Attacking(Plant plant)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        this.plant = plant;
    }
    

    public void AttackPlant(float damage)  // Event
    {
        plant.GetComponent<Health>().DealDamage(damage);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="destroy")
        {
            DecreasePoint();

        }
        else if(collision.gameObject.tag == "projectile")
        {
            hurtAttack();
        }
    }
    private void hurtAttack()
    {
        GetComponent<Health>().DealDamage(FindObjectOfType<projectile>().GetDamage());
    }

    private void DecreasePoint()
    {
        Debug.Log("minhfsdfasdf");
        Destroy(gameObject);
        FindObjectOfType<HealthPlayer>().DecreaseHealth();
    }
}
