using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Player_Control movement;
  //  [SerializeField]
    public GameObject hitByCarText;
    public GameObject victoryText;
    public AudioClip vicSound;
    public AudioClip crash;
    public AudioClip victory;
    private AudioSource AudioSource;

    public GameObject target;
    public GameObject trigger;
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject trigger4;
    public GameObject trigger5;
    public GameObject trigger6;
    public GameObject trigger7;

    //Searches and moves toward the target
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target");
    }
    private void Awake()
    {
        AudioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Car") //Collides with Car
        {
            hitByCarText.SetActive(true);
            movement.enabled = false; // Disable player movement.
            FindObjectOfType<GameManager>().EndGame();
            AudioSource.PlayOneShot(crash);
          
        }
        if (col.gameObject.tag == "Kissa")
        {
            victoryText.SetActive(true); //Collides with the Cat
            movement.enabled = false; // Disable player movement.
            FindObjectOfType<GameManager>().EndGame(); // Ends the game
            AudioSource.PlayOneShot(victory);
            AudioSource.PlayOneShot(vicSound);


        }
    }
    private void OnTriggerEnter(Collider other)
    {

        //Collides with Triggers.
        if (other.gameObject.tag == "Trigger0")
        {

            trigger.SetActive(false);
            Debug.Log("Trigger 0");
            target.transform.position = new Vector3(89f, 1f, 175.68f);

        }
        if (other.gameObject.tag == "Trigger1")
        {

            trigger1.SetActive(false);
            Debug.Log("Trigger 1");
            target.transform.position = new Vector3(90.2f, 1f, 223.8f);
        }
        if (other.gameObject.tag == "Trigger2")
        {

            trigger2.SetActive(false);
            Debug.Log("Trigger 2");
            target.transform.position = new Vector3(128.7f, 1f, 223.8f);
        }
        if (other.gameObject.tag == "Trigger3")
        {

            trigger3.SetActive(false);
            Debug.Log("Trigger 3");
            target.transform.position = new Vector3(110.2f, 1f, 155.7f);
        }
        if (other.gameObject.tag == "Trigger4")
        {

            trigger4.SetActive(false);
            Debug.Log("Trigger 4");
            target.transform.position = new Vector3(106f, 1f, 119.1f);
        }
        if (other.gameObject.tag == "Trigger5")
        {

            trigger5.SetActive(false);
            Debug.Log("Trigger 5");
            target.transform.position = new Vector3(61.1f, 1f, 119.1f);
        }
        if (other.gameObject.tag == "Trigger6")
        {

            trigger6.SetActive(false);
            Debug.Log("Trigger 6");
            target.transform.position = new Vector3(64.2f, 1f, 151.2f);
        }
        if (other.gameObject.tag == "Trigger7")
        {
            trigger7.SetActive(false);
            Debug.Log("Trigger 7");
            target.transform.position = new Vector3(87.6f, 1f, 152.2f);
        }
    
    }
}