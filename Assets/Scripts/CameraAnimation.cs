using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour
{
    private Vector3 cameraPosition;
    void Start()
    {
        cameraPosition = transform.position;
        transform.position=new Vector3(cameraPosition.x, cameraPosition.y-6f, cameraPosition.z);
    }


    void Update()
    {
        transform.position=Vector3.Lerp(transform.position,cameraPosition,2*Time.deltaTime);
        
    }
}
