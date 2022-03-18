using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
   Plant plant;
    const string PARENT_DEFENDER = "Parent Defender";
    GameObject parentDefender;
    GameObject parentProjectile;
    private void Start()
    {
        if(!parentDefender)
        {
            parentDefender = new GameObject(PARENT_DEFENDER);
        }
        if(!parentProjectile)
        {
            parentProjectile = new GameObject("Parent Projectile");
        }
       
    }
    private void OnMouseDown()
    {
        Vector2 pos = convertPosMouse();
        SpawnDefender(pos);
    }

    public void SetPlant (Plant plant)
    {
        this.plant = plant;
    }
    private Vector2 convertPosMouse()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return convertInt(pos);
    }
    private Vector2 convertInt(Vector2 pos)
    {
        int x = Mathf.RoundToInt(pos.x);
        int y = Mathf.RoundToInt(pos.y);
        return new Vector2(x, y);
    }
    private void SpawnDefender(Vector2 pos)
    {
        if (!OnePlantPerSquare(pos))
        {
            if (FindObjectOfType<StarDisplay>().GetCurrenStar() >= plant.GetStarCost())
            {
                FindObjectOfType<StarDisplay>().SpendStar(plant.GetStarCost());
                var tmp = Instantiate(plant, pos, Quaternion.identity);
                tmp.transform.parent = parentDefender.transform;
               

            }
        }
        
    }

    private bool OnePlantPerSquare(Vector2 pos)
    {
        var plantInGame = FindObjectsOfType<Plant>();
        for (int i = 0; i < plantInGame.Length; i++)
        {
            if (pos.x == plantInGame[i].transform.position.x && pos.y == plantInGame[i].transform.position.y )
            {
                return true;
            }
        }
        
        return false;
    }

}
