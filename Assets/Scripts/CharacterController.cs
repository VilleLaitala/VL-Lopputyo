using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {


    public float inputDelay = 0.1f;
    public float forwardVel = 12;
    public float rotateVel = 100;

    Quaternion targetRotation;
    Rigidbody rb;
    float forwardInput, turnInput;
    public Quaternion TargetRotation
    {
        get { return targetRotation; }

    }
    void Start()
    {
        targetRotation = transform.rotation;
        if (GetComponent<Rigidbody>())
            rb = GetComponent<Rigidbody>();
        else
            Debug.LogError("The Chr needs a rigidbody.");

        forwardInput = turnInput = 0;
    }

    void GetInput()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }
    void Update()
    {


    }
    void FixedUpdate()
    {

    }
    void Run()
    {
        if (Mathf.Abs(forwardInput) > inputDelay)
        {
            //move
            rb.velocity = transform.forward * forwardInput * forwardVel;
        }
        else //zero velocity
            rb.velocity = Vector3.zero;
    }
    void Turn()
    {
        if (Mathf.Abs(forwardInput) > inputDelay)
        {
            targetRotation *= Quaternion.AngleAxis(rotateVel * turnInput * Time.deltaTime, Vector3.up);
        }
        transform.rotation = targetRotation;
    }
}