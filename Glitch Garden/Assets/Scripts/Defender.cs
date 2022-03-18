using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    AttackSpawner attSpawnerOnThatLane;
    Animator animator;

    private void Start()
    {
        SetAttackSpawner();
        animator = GetComponent<Animator>();
    }
    public void Fire(float speed)
    {
            var proj = Instantiate(projectile, gun.transform.position, Quaternion.identity);
            proj.GetComponent<projectile>().SetSpeed(speed);
        proj.transform.parent = GameObject.Find("Parent Projectile").transform;
     }
    private void Update()
    {
        if(AnyEnemyOnThatLane())
        {
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }
    public void SetAttackSpawner()
    {
        var arrayAtt = FindObjectsOfType<AttackSpawner>();
        foreach(AttackSpawner tmp in arrayAtt)
        {
            bool isCloseEnough = (transform.position.y - tmp.transform.position.y <= Mathf.Epsilon); 
            if(isCloseEnough)
            {
                attSpawnerOnThatLane = tmp;
                return;
            }
        }
    }

    private bool AnyEnemyOnThatLane()
    {
        if (attSpawnerOnThatLane.transform.childCount > 0) return true;
        return false;
    }

    
  
}
