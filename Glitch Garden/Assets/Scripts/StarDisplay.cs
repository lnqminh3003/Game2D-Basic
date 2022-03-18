using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int star;
    TextMeshProUGUI starText;
    private void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        starText.text = star.ToString();
    }
    public void AddStar(int amount)
    {
        star += amount;
    }
    public void SpendStar(int amount)
    {
        if(star >= amount)
        {
            star -= amount;
        }
    }
    public int GetCurrenStar()
    {
        return star;
    }
   
}
