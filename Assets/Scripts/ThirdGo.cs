using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdGo : MonoBehaviour {

    public GameObject stop3;

    public GameObject go3;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Car")
        {

            Debug.Log("Car on Go 2");

            go3.SetActive(true);
            stop3.SetActive(false);
        }
    }
}