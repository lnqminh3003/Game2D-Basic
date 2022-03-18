using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Tooltip("Time per second.")]
    [SerializeField] float levelTime = 10f;
    bool checkTimeZero = false;
    bool triggerFinished = false;
    void Update()
    {
        if (triggerFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        if (Time.timeSinceLevelLoad >= levelTime)
        {
            checkTimeZero = true;
            triggerFinished = true;
        }
    }
    public bool CheckTimeZero()
    {
     
        return checkTimeZero;
        
    }
}
