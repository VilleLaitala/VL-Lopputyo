using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour, IPoolable
{

    // public bool isMoving;
    // public bool isGrounded;
   // [SerializeField]
   
    public float CarSpeed = 50f;
    Rigidbody CarRb;
    Animator CarAnim;
    public event Action OnDestroyEvent = delegate { };
    // Use this for initialization
    private void OnDisable() { OnDestroyEvent(); }
    public void Start()
     {

        // transform.Translate(Vector3.forward * Time.deltaTime * CarSpeed);
        CarRb = GetComponent<Rigidbody>();
         //CarAnim = GetComponent<Animator>();

        // isGrounded = true;


     }

    // Update is called once per frame
  
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * CarSpeed);
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