using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        GameObject colli = collision.gameObject;
        if(colli.GetComponent<Plant>())
        {
            Plant plant = colli.GetComponent<Plant>();
            GetComponent<Attack>().Attacking(plant);
        }
        
    }
}
