using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    public AudioClip voiceEfect;
    private GameObject Ball;
    void Start()
    {
        Ball = GameObject.Find("Ball");
    }

    void Update()
    {
        Vector3 mousePos=Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y,10f));
         transform.position = new Vector3(Mathf.Clamp(mousePos.x,-4.88f,4.88f),transform.position.y,transform.position.z);


        //otomatik oyun
      //  transform.position = new Vector3(Ball.transform.position.x,transform.position.y,transform.position.z);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(voiceEfect, transform.position);

    }
}
