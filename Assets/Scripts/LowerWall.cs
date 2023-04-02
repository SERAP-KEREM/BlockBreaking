using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LowerWall : MonoBehaviour
{
    public int againPlay = 3;
    public GameObject ball;
    public GameObject pedal;
    public Vector3 ballPos;
    public Text liveText;

    Ball ballScript;
    private void Start()
    {
        ballScript= ball.GetComponent<Ball>();
        liveText.text = "Live : " + (int)againPlay;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("Ball"))
        {
            againPlay--;
            liveText.text = "Live : " + (int)againPlay;
            if(againPlay> 0)
            {
                ball.transform.position = new Vector3(pedal.transform.position.x,pedal.transform.position.y+0.2f, pedal.transform.position.z);
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0f);
                ballScript.isStartGame = false;
            }
            else
            {
              SceneManager.LoadScene("LoseGame");
            }
        }
    }
}
