using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour

{

    public GameObject text;
    bool gameHasEnded = false;
   // public float restartDelay = 3;
    public void EndGame()

    {
        if (gameHasEnded == false)

        {
            text.SetActive(true);
            gameHasEnded = true;
            Debug.Log("Hit by Car");
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
           // Invoke("Restart", restartDelay / Time.timeScale);

   /* void Restart()
    {

        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
