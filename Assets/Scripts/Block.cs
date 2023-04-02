using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Block : MonoBehaviour
{
    public GameObject breakEffect;
    public AudioClip voiceEfectBreaking;
    public AudioClip voiceEfectImpact;
    public static int totalNumberOfBlock;
    public Sprite[] blockSprite;
    private int maxNumberOfHits;
    public int numberOfHits;

    


    private PuanSystem puanSystem;

    void Start()
    {
        maxNumberOfHits=blockSprite.Length+1;
        totalNumberOfBlock++;
        puanSystem=GameObject.FindObjectOfType<PuanSystem>().GetComponent<PuanSystem>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.name.Equals("Ball"))
        {
            puanSystem.AddPuad();
            numberOfHits++;
           
            if(numberOfHits >= maxNumberOfHits)
            {
                totalNumberOfBlock--;
                
               puanSystem.PuanReturn();
                if(totalNumberOfBlock <= 0)
                {
                    GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>().NextScene();
                }
                Vector3 position = collision.contacts[0].point;
                GameObject go = Instantiate(breakEffect, position, Quaternion.identity) as GameObject;
                Color blockColor = GetComponent<SpriteRenderer>().color;
                go.GetComponent<ParticleSystemRenderer>().material.color = blockColor;
                Destroy(go, 1f);
                AudioSource.PlayClipAtPoint(voiceEfectBreaking, transform.position);
                Destroy(gameObject);
               
            }
            else
            {
         
                AudioSource.PlayClipAtPoint(voiceEfectImpact, transform.position);
                GetComponent<SpriteRenderer>().sprite = blockSprite[numberOfHits - 1];
            }
        }
    }
}
