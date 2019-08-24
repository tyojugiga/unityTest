using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychanScript : MonoBehaviour
{

    private Animator animator;
    private new Rigidbody  rigidbody;
    Vector3 UnitychanPos;

    public float speed = 5.0f;
    public float up = 200f;
    private int flag = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("running", true);

            if (Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetBool("runRight", true);
            }
            else
            {
                animator.SetBool("runRight", false);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                animator.SetBool("runLeft", true);
            }
            else
            {
                animator.SetBool("runLeft", false);
            }

            float z = speed * Time.fixedDeltaTime;
            float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime;
            Vector3 vector = new Vector3(x, 0, z);
            vector = transform.TransformDirection(vector);
            rigidbody.MovePosition(transform.position + vector);

            if (flag == 0)
            {
                Vector3 direction = transform.position - UnitychanPos;

                if (direction.magnitude > 0.01f)
                {
                    transform.rotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
                }

            }

        }
        else
        {
            animator.SetBool("running", false);
        }

        UnitychanPos = transform.position;

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("jumping", true);
            

        }
        else
        {
            animator.SetBool("jumping", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rigidbody.velocity.y == 0)
            {
                rigidbody.AddForce(Vector3.up * up);
            }
        }

        if (Input.GetKey(KeyCode.Z))
        {
            animator.SetBool("atacking1", true);
            rigidbody.AddForce(Vector3.forward * speed);
        }
        else
        {
            animator.SetBool("atacking1", false);
        }

        if (Input.GetKey(KeyCode.X))
        {
            animator.SetBool("winning", true);
        }
        else
        {
            animator.SetBool("winning", false);
        }
        
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "cube")
        {
            flag = 1;
        }
        else
        {
            flag = 0;
        }
    }


}
