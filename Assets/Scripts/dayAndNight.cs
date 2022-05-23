using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayAndNight : MonoBehaviour
{
    public GameObject day;
    public GameObject night;
    void Start()
    {
        if (PlayerPrefs.GetInt("playerScore") > 20)
        {
            day.SetActive(false);
            night.SetActive(true);
        }
        else
        {
            day.SetActive(true);
            night.SetActive(false);
        }
    }

    
}
