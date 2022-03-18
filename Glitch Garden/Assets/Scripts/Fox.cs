using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    bool checkJump = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "GraveStone")
        {
            checkJump = false;
            if (checkJump == false)
            {
                GetComponent<Animator>().SetBool("Jumping", true);
            }
           
        }
        else if(collision.tag  == "Plant")
        {
            GetComponent<Attack>().Attacking(collision.gameObject.GetComponent<Plant>());
        }
    }

    public void SetState()
    {
        GetComponent<Animator>().SetBool("Jumping", false);
    }

   
}
