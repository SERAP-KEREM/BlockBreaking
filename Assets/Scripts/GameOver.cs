using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text puanText;


    private void Start()
    {
        puanText.text = "Puan : " +GameObject.FindObjectOfType<PuanSystem>().GetComponent<PuanSystem>().PuanReturn();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
