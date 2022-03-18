using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField] float damage;

    float speedProjectile;

    private void Update()
    {
        transform.Translate(Vector2.right * speedProjectile * Time.deltaTime);
    }
    public void SetSpeed(float speed)
    {
        speedProjectile = speed;
    }
    public float GetDamage()
    {
        return damage;
    }
   
}
