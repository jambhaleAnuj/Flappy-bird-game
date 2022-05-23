using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearHighScore : MonoBehaviour
{
    public void onClick()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }
}
