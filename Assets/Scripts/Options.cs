using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Options : MonoBehaviour
{
    [SerializeField] Slider slider;
    const string diffLevel="Difficulty";
    const int MAX_DIFF = 3;
    const int MIN_DIFF = 1;
  

    public static void SetPrefsNum(int num)
    {
        if (num >= 1 && num <= 3) { PlayerPrefs.SetInt(diffLevel, num); }
        else { Debug.LogError("Hernia"); } 
    }
    private void Update()
    {
        SetPrefsNum((int)slider.value);
    }
    public static int GetPrefsNum()
    {
      return PlayerPrefs.GetInt(diffLevel); 
    }
}
