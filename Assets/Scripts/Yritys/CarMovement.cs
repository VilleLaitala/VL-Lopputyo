using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour, IPoolable
{

    // public bool isMoving;
    // public bool isGrounded;
    [SerializeField]
    public bool isMoving;
    public float CarSpeed = 1.5f;
    
    Rigidbody CarRb;
    Animator CarAnim;
    public event Action OnDestroyEvent = delegate { };
    // Use this for initialization
    private void OnDisable() { OnDestroyEvent(); }
    public void Start()
    {
        
        isMoving = true;
        CarRb = GetComponent<Rigidbody>();
        //CarAnim = GetComponent<Animator>();

        // isGrounded = true;

    }
    

    // Update is called once per frame

    private void FixedUpdate()
   
        {
            if (isMoving == true)
            {
                transform.Translate(0f, 0f, 1.5f);
                Debug.Log("Is moving");

            }
            if (isMoving == false)
            {

                transform.Translate(0f, 0f, 0f);
                Debug.Log("Is not moving");

            }
        }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Stop")
        {

            Debug.Log("Collided with Stop");
            isMoving = false;
        }
        else
        {
            if (other.gameObject.tag == "Go")
            {
                Debug.Log("Collided with Go");
                isMoving = true;
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            gameObject.SetActive(false);
            Debug.Log("Collided");

        }
       
        }
    }
