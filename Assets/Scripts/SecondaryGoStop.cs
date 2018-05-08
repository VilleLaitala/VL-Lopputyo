using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryGoStop : MonoBehaviour
{
    public GameObject stop2;


    public GameObject go2;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Car")
        {

            Debug.Log("Car on Stop 1");
            stop2.SetActive(true);

            go2.SetActive(false);

        }
    }
}