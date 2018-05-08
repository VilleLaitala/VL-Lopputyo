using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public Player_Control movement;
    [SerializeField]
    public AudioClip crash;

    private AudioSource AudioSource;
   
    private void Awake()
    {
        AudioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Car")
        {
            
            movement.enabled = false; // Disable player movement.
            FindObjectOfType<GameManager>().EndGame();
            AudioSource.PlayOneShot(crash);
            movement.enabled = true; // Enable player movement.
        }
    }
}