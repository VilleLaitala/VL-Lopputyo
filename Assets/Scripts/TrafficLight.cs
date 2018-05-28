using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class TrafficLight : MonoBehaviour
{
    public AudioClip redL;
    public AudioClip greenL;
    public AudioSource audioSource;
    
    public GameObject stop0;
    public GameObject stop1;

    public GameObject go0;
    public GameObject go1;

    public Animator anim;
    // Use this for initialization
    void Start()
    {
        
        anim = GetComponent<Animator>();
        StartCoroutine("Trafficlight");

    }
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    private IEnumerator Trafficlight()
    {
        while (true)
        {
            
          
            
            // Playing Green
            anim.SetBool("RedLight", false);
            anim.SetBool("GreenLight", true);
            anim.SetBool("YellowLight", false);
            //Play Greenlight sound
            audioSource.clip = greenL;
            
            audioSource.Play();
            // Set Stops active, disable go's
            stop0.SetActive(true);
            stop1.SetActive(true);
            go0.SetActive(false);
            go1.SetActive(false);
            yield return new WaitForSeconds(5.0f);
          //  Playing Yellow
            anim.SetBool("RedLight", false);
            anim.SetBool("GreenLight", false);
            anim.SetBool("YellowLight", true);
            yield return new WaitForSeconds(5.0f);
            // Playing Red
            // disable Stops active, set go's active
            anim.SetBool("RedLight", true);
            anim.SetBool("GreenLight", false);
            anim.SetBool("YellowLight", false);

            //Play Red Light Sound
            audioSource.clip = redL;
            audioSource.Play();
            stop0.SetActive(false);
            stop1.SetActive(false);
            go0.SetActive(true);
            go1.SetActive(true);
            
            yield return new WaitForSeconds(10.0f);

        }
    }
}
