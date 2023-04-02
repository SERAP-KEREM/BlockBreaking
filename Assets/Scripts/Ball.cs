using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private GameObject pedal;
    public bool isStartGame=false;
    public Text puanText;
    Block block;
    void Start()
    {
        pedal=GameObject.FindObjectOfType<Pedal>().gameObject;

    }

    void Update()
    {
        if(!isStartGame)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);

        }
        if (Input.GetMouseButton(0)&&!isStartGame)
        {
            isStartGame=true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
        puanText.text = "Puan : " + GameObject.FindObjectOfType<PuanSystem>().GetComponent<PuanSystem>().PuanReturn();
    }

   
}
