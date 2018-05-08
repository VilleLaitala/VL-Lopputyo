using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdGoStop : MonoBehaviour
{

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

            Debug.Log("Car on Stop 2");

            stop3.SetActive(true);

            go3.SetActive(false);
        }
    }
}