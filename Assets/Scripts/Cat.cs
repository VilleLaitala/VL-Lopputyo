using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Cat : MonoBehaviour {

    public Transform[] target;
    public float speed;
    private int current;

    public AudioClip[] audioClips;

    public AudioSource audioSource;
    void Start()
    {

        CallAudio();
    }
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.fixedDeltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % target.Length;
	}
    void CallAudio()
    {
        Invoke("RandomSound", 2);
    }
    void RandomSound()
    {
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
        CallAudio();
    }
}


