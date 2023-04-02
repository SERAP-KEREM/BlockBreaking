using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour
{
    public AudioClip voiceEfect;
    public GameObject impactEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(voiceEfect, transform.position);
        Vector3 position = collision.contacts [0].point;
        GameObject gameObject = Instantiate(impactEffect, position, Quaternion.identity)as GameObject;
        Destroy(gameObject,1f);
        
    }
}
