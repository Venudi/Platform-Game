using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool LevelComplete = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !LevelComplete)
        {
            finishSound.Play();
            LevelComplete = true;
            Invoke("CompleteLevel", 1f); // Invoke() calls a function after a delay (in seconds)
        }
    }

    private void CompleteLevel()
    {
        // Debug.Log("Level Complete!");
        // add strawberries to global strawberries
        PlayerLife.strawberriesGlobal += ItemCollector.globalStrawberries;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
