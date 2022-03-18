using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestGame : MonoBehaviour
{
    [SerializeField] GameObject slider;
    private void Start()
    {
        PlayerPresController.SetVolumeKey(0.4f);
        Slider sliderVolume = GetComponent<Slider>();
        Debug.Log(PlayerPresController.GetVolumeKey());
    }
    private void Update()
    {
        
    }
}
