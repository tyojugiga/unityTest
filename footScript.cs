using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footScript : MonoBehaviour
{
    GameObject[] c = new GameObject[5];
    GameObject[] g = new GameObject[5];

    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            c[i] = GameObject.Find("c" + i);
            g[i] = GameObject.Find("GameObject" + i);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name.StartsWith("c"))
        {
            for(int i = 0; i < 5; i++)
            {
                if (c[i] == collider.gameObject)
                {
                    ParticleSystem ps = g[i].GetComponent<ParticleSystem>();
                    ps.Play();
                    Destroy(collider.gameObject);
                }
            }
        }


    }
}
