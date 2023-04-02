using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void OtherScene()
    {
        Block.totalNumberOfBlock = 0;
        GameObject.FindObjectOfType<PuanSystem>().GetComponent<PuanSystem>().ResetPuan();
        SceneManager.LoadScene("Level1");

    }
   
}
