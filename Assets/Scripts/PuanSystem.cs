using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuanSystem : MonoBehaviour
{
    private int puan;
    public void AddPuad()
    {
        puan++;
    }

    public int PuanReturn()
    {
        return puan;
    }

    public void ResetPuan()
    {
        puan = 0;   
    }

  
}
