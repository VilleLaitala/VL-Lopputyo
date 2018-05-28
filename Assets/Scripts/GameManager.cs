using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour {

    public GameObject startGameText;
    public AudioClip startSound;

    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }

    IEnumerator Start()
    {
        startGameText.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        audioSource.PlayOneShot(startSound);
        yield return new WaitForSecondsRealtime(2);
        startGameText.SetActive(false);
        
    }
   
    bool gameHasEnded = false;
   
    public void EndGame()

    {
        if (gameHasEnded == false)

        {
            gameHasEnded = true;
            
            Time.timeScale = .001f;
            StartCoroutine(Restart());
        }
    }
        IEnumerator Restart()
        {
        yield return new WaitForSecondsRealtime(3);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;

    }
    }
