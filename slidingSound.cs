﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidingSound : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
