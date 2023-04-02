using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    static bool IsActiveSound;
    void Start()
    {
        if(!IsActiveSound)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            IsActiveSound = true;
        }
        else
        {
            Destroy(gameObject);
        }


    }
}

    
