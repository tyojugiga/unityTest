using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    private GameObject player;
    private Vector3 offset;

    void Start()
    {
        player = GameObject.Find("unitychan");
        offset = transform.position - player.transform.position;
    }

    
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
