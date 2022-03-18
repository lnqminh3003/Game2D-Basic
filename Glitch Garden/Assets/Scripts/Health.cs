using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] GameObject deathEffect;   
    public void DealDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            
            if (GetComponent<Attack>())
            {
                var effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
                Destroy(effect, 2f);
                
            }
            FindObjectOfType<LevelController>().AttackKilled();
            Destroy(gameObject);
            
        }
    }
    
}
