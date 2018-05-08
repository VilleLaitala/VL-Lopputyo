using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    
    public GameObject stop0;
    public GameObject stop1;
    
    
    public GameObject go0;
    public GameObject go1;
    

    // private CarMovement stopScript;
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine("Trafficlight");
    }
    private IEnumerator Trafficlight()
    {
        while (true)
        {
            Debug.Log("Playing Red");
            anim.SetBool("RedLight", true);
            anim.SetBool("GreenLight", false);
            anim.SetBool("YellowLight", false);
            stop0.SetActive(true);
            stop1.SetActive(true);
            go0.SetActive(false);
            go1.SetActive(false);
            yield return new WaitForSeconds(5.0f);
            Debug.Log("Playing Green");
            anim.SetBool("RedLight", false);
            anim.SetBool("GreenLight", true);
            anim.SetBool("YellowLight", false);
            stop0.SetActive(false);
            stop1.SetActive(false);
            go0.SetActive(true);
            go1.SetActive(true);
            yield return new WaitForSeconds(5.0f);
            Debug.Log("Playing Yellow");
            anim.SetBool("RedLight", false);
            anim.SetBool("GreenLight", false);
            anim.SetBool("YellowLight", true);
            yield return new WaitForSeconds(5.0f);

        }
    }
}
