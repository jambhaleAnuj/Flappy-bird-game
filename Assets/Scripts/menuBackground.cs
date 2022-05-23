using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class menuBackground : MonoBehaviour
{
    public GameObject day;
    public GameObject night;
    void Start()
    {
        
        if(DateTime.Now.Hour < 19)
        {
            day.SetActive(true);
            night.SetActive(false);
        }
        else
        {
            day.SetActive(false);
            night.SetActive(true);
        }

        
    }

    
}
