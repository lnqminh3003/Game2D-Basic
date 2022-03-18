using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] int starCost;
    public void AddStarts(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStar(amount);
    }
    public int GetStarCost()
    {
        return starCost;
    }    
}
