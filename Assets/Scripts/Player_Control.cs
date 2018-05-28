using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public bool isGrounded;
    public bool isCrouching;

    private float speed;
    private float w_speed = 0.07f;
    private float wb_speed = 0.015f;
    private float r_speed = 0.2f;
    private float c_speed = 0.015f;

    public float rotSpeed;
    public float jumpHeight;

    Rigidbody rb;
    Animator anim;
    CapsuleCollider col_size;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        col_size = GetComponent<CapsuleCollider>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Toggle Crouch
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (isCrouching)
            {
                isCrouching = false;
                anim.SetBool("isCrouching", false);
                col_size.height = 2;
                col_size.center = new Vector3(0, 1, 0);

            }
            else
            {
                isCrouching = true;
                anim.SetBool("isCrouching", true);
                speed = c_speed;
                col_size.height = 1;
                col_size.center = new Vector3(0, 0.5f, 0);
            }
        }
        var z = Input.GetAxis("Vertical") * speed;
        var y = Input.GetAxis("Horizontal") * rotSpeed;

        transform.Translate(0, 0, z);
        transform.Rotate(0, y, 0);

        /* if (Input.GetKey(KeyCode.Space) && isGrounded == true)
         {
             rb.AddForce(0, jumpHeight, 0);
             anim.SetTrigger("isJumping");
             isCrouching = false;
             isGrounded = false;

         }*/
        if (isCrouching)
        {
            //Crouch controls
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("isWalking", true);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", false);

            }
            else if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isWalking", true);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", false);
            }
            else
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", true);
            }
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {

            //Running controls
            if (Input.GetKey(KeyCode.W))
            {
                speed = r_speed;
                anim.SetBool("isWalking", false);
                anim.SetBool("isIdle", false);
                anim.SetBool("isRunning", true);

            }
            else if (Input.GetKey(KeyCode.S))
            {
                speed = wb_speed;
                anim.SetBool("isWalking", true);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", false);
            }
            else
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", true);
            }
        }
        else if (!isCrouching)
        {

            //Standing controls
            if (Input.GetKey(KeyCode.W))
            {
                speed = w_speed;
                anim.SetBool("isWalking", true);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", false);

            }
            else if (Input.GetKey(KeyCode.S))
            {
                speed = wb_speed;
                anim.SetBool("isWalking", true);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", false);
            }
            else
            {
                //speed = w_speed;
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", true);
            }

        }
    }
        void OnCollisionEnter()
        {
            isGrounded = true;
        }
    }


