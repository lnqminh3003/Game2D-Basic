using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Plant plant;
    [SerializeField] Text textCost;

    private void Start()
    {
        textCost.GetComponent<Text>().text = plant.GetStarCost().ToString();
    }
    private void OnMouseDown()
    {
        changeColor();
    }

    private void changeColor()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton i in buttons)
        {
            i.GetComponent<SpriteRenderer>().color = new Color32(94, 94, 94, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetPlant(plant);
        
    }
}
