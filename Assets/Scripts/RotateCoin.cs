﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{


    void Update()
    {

        transform.Rotate(new Vector3(0f, Time.deltaTime + 0.5f, 0f));
        
    }
}
