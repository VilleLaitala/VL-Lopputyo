using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
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
            yield return new WaitForSeconds(5.0f);
            Debug.Log("Playing Green");
            anim.SetBool("RedLight", false);
            anim.SetBool("GreenLight", true);
            anim.SetBool("YellowLight", false);
            yield return new WaitForSeconds(5.0f);
            Debug.Log("Playing Yellow");
            anim.SetBool("RedLight", false);
            anim.SetBool("GreenLight", false);
            anim.SetBool("YellowLight", true);
            yield return new WaitForSeconds(5.0f);

        }
    }
}
