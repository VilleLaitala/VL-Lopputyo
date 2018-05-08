using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGo : MonoBehaviour
{


    public GameObject stop2;
    public GameObject go2;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Car")
        {

            Debug.Log("Car on Go");
            
            go2.SetActive(true);
            stop2.SetActive(false);
        }
    }
}