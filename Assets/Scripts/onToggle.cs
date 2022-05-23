using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onToggle : MonoBehaviour
{
    public void Toggle_Changed(bool newValue)
    {

        Debug.Log("Toggled");
        if(newValue== true)
        {
            Debug.Log("True");
            PlayerPrefs.SetInt("dayAndNight", 0);
        }
        else if (newValue == false)
        {
            PlayerPrefs.SetInt("dayAndNight", 1);
            Debug.Log("False");
        }

    }
}
