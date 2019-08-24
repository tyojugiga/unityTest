using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript2 : MonoBehaviour
{

    public float plus = 0.1f;
    private int counter = 0;
    Vector3 p;
    new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        p = new Vector3(plus, 0, 0);
        rigidbody.MovePosition(transform.position + p);
        counter++;
        if (counter == 100)
        {
            counter = 0;
            plus *= -1;
        }
    }
}
