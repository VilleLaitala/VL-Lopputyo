using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour, IPoolable
{

    public AudioClip[] notMoving;
    public AudioClip moving;
    public AudioSource audioSource;

    public bool isMoving;
    public float CarSpeed;

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
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }


    // Update is called once per frame

    private void Update()

    {
        if (isMoving == true) // If true, Car moves.
        {
            transform.Translate(0f, 0f, CarSpeed);
            //  Is moving
            audioSource.clip = moving;
            audioSource.loop = true;
            audioSource.Play();

        }
        if (isMoving == false) // If false, Car doesn't moves.
        {
            transform.Translate(0f, 0f, 0f); //  Is not moving
            audioSource.clip = moving;

            audioSource.Stop();
            Invoke("RandomNotMovingSound", 5);


        }
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Stop")
        {

            //Collided with Stop set isMoving false
            isMoving = false;
        }
        else
        {
            if (other.gameObject.tag == "Go")
            {
                //Collided with Go set isMoving true
                isMoving = true;
            }
        }
    }
    void RandomNotMovingSound()
    {
        if (gameObject.activeInHierarchy)
        {

            audioSource.clip = notMoving[UnityEngine.Random.Range(0, notMoving.Length)];
            audioSource.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall") // if Collides with wall set the gameObject active false.
        {
            

            
            gameObject.SetActive(false);


        }
    }


}