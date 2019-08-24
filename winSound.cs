using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winSound : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
