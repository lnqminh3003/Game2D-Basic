using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultController : MonoBehaviour
{
    [SerializeField] GameObject sliderDifficulty;
    Slider slider;
    private void Start()
    {
        slider = sliderDifficulty.GetComponent<Slider>();
        slider.value =PlayerPresController.GetDifficultKey();
    }
    private void Update()
    {
        PlayerPresController.SetDifficulty(slider.value);
    }
    public void SetDefaultDiff()
    {
        slider.value = PlayerPresController.GetDifficultKey();
    }
}
