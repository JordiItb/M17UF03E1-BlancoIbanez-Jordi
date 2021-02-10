using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{

    public float rotatingSpeed;
    private float rotationX;
    private float rotationZ;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        rotationX = Mathf.Clamp(rotationX, -25f, 25f);
        
        if(Input.GetAxis("Vertical") != 0){

            rotationX += Input.GetAxis("Vertical") * rotatingSpeed * Time.deltaTime;

            transform.localRotation = Quaternion.Euler(rotationX, 0f, rotationZ);
            

        }

        rotationZ = Mathf.Clamp(rotationZ, -25f, 25f);

        if(Input.GetAxis("Horizontal") != 0){


            rotationZ += -Input.GetAxis("Horizontal") * rotatingSpeed * Time.deltaTime;

            transform.localRotation = Quaternion.Euler(rotationX, 0f, rotationZ);

        }


    }
}
