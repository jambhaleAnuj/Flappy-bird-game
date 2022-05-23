using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onLoadDontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        for(int i =0; i < Object.FindObjectsOfType<onLoadDontDestroy>().Length; i++)
        {
            if (Object.FindObjectsOfType<onLoadDontDestroy>()[i] != this)
            {
                if (Object.FindObjectsOfType<onLoadDontDestroy>()[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }
        }
        DontDestroyOnLoad(gameObject);
    }


}
