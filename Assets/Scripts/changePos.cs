using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePos : MonoBehaviour
{

    public GameObject target;
    public GameObject trigger;
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject trigger4;
    public GameObject trigger5;
    public GameObject trigger6;
    public GameObject trigger7;

    public int counter;
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && counter == 0)
        {
            counter += 1;
            trigger.SetActive(false);
            target.transform.position = new Vector3(89f, 0.041f, 175.68f);

        }
        if (counter == 1 && other.gameObject.tag == "Player" )
        {
            ++counter;
            trigger1.SetActive(false);
            target.transform.position = new Vector3(90.2f, 0.041f, 223.8f);
        }
        if (other.gameObject.tag == "Player" && counter == 2)
        {
            ++counter;
            trigger2.SetActive(false);
            target.transform.position = new Vector3(128.7f, 0.041f, 223.8f);
        }
        if (other.gameObject.tag == "Player" && counter == 3)
        {
            ++counter;
            trigger3.SetActive(false);
            target.transform.position = new Vector3(110.2f, 0.041f, 155.7f);
        }
        if (other.gameObject.tag == "Player" && counter == 4)
        {
            ++counter;
            trigger4.SetActive(false);
            target.transform.position = new Vector3(106f, 0.041f, 119.1f);
        }
        if (other.gameObject.tag == "Player" && counter == 5)
        {
            ++counter;
            trigger5.SetActive(false);
            target.transform.position = new Vector3(61.1f, 0.041f, 119.1f);
        }
        if (other.gameObject.tag == "Player" && counter == 6)
        {
            ++counter;
            trigger6.SetActive(false);
            target.transform.position = new Vector3(64.2f, 0.041f, 151.2f);
        }
        if (other.gameObject.tag == "Player" && counter == 7)
        {
            ++counter;
            trigger7.SetActive(false);
            target.transform.position = new Vector3(87.6f, 0.041f, 152.2f);
        }
    }
}