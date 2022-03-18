using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerPresController : MonoBehaviour
{
    const string VOLUME_KEY = "volume";
    const string DIFFICULTY_KEY = "difficulty";
    public static void SetVolumeKey(float volume)
    {
        if (volume >= 0f && volume <= 1f)
        {
           
            PlayerPrefs.SetFloat(VOLUME_KEY, volume);
        }
    }
    public static void SetDifficulty(float diff)
    {
        if(diff >= 0f && diff <= 1f)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, diff);
        }
    }

    public static float GetVolumeKey()
    {
       return PlayerPrefs.GetFloat(VOLUME_KEY);
    }
    public static float GetDifficultKey()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
    
    
}
