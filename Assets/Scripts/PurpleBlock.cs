using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBlock: MonoBehaviour
{
    LowerWall lowerWall;
    PuanSystem puanSystem;
    public GameObject breakEffect;
    private void Start()
    {
        lowerWall = GameObject.FindObjectOfType<LowerWall>().GetComponent<LowerWall>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Equals("Ball"))
        {

             lowerWall.againPlay++;
            lowerWall.liveText.text = "Live : " + lowerWall.againPlay;

            Vector3 position = collision.contacts[0].point;
            GameObject go = Instantiate(breakEffect, position, Quaternion.identity) as GameObject;
            Color blockColor = GetComponent<SpriteRenderer>().color;
            go.GetComponent<ParticleSystemRenderer>().material.color= blockColor;
            Destroy(go, 1f);


            Destroy(gameObject);

        }
    }
}
