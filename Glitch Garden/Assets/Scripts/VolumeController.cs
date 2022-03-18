using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] GameObject sliderVolume;
    Slider slider;
    private void Start()
    {
        slider = sliderVolume.GetComponent<Slider>();
        slider.value = PlayerPresController.GetVolumeKey();
    }
    private void Update()
    {
        if (slider)
        {
            PlayerPresController.SetVolumeKey(slider.value);
            FindObjectOfType<Music>().GetComponent<AudioSource>().volume = PlayerPresController.GetVolumeKey();
        }

    }
    public void SetDefaultSlider(float value)
    {
        slider.value = value;
    }
}
