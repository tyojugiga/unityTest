using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    private GameObject player;
    Vector3 playerPos;
    public float rotateSpeed = 178f;

    void Start()
    {
        player = GameObject.Find("unitychan");
        playerPos = player.transform.position;
    }

    
    void Update()
    {
        transform.position += player.transform.position-playerPos;
        playerPos = player.transform.position;

        float y = Input.GetAxis("Horizontal");
        transform.RotateAround(playerPos, Vector3.up, y * Time.deltaTime * rotateSpeed);
    }
}
