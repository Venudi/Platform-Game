using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class PlayerLife : MonoBehaviour
{
    // lives global variable
    public static int lives = 5;

    // rigid body 2d
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource deathSound;

    private void Start()
    {
        // get objects with tag "Heart" in order of appearance
        GameObject[] hearts = GameObject.FindGameObjectsWithTag("Heart").OrderBy(go => go.name).ToArray();

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        // disable hearts
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].SetActive(false);
        }
        // enable hearts
        for (int i = 0; i < lives; i++)
        {
            hearts[i].SetActive(true);
        }
    }

    // oncollisionenter2d
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    // die
    private void Die()
    {
        // reduce lives
        lives--;
        // play death sound
        deathSound.Play();
        // set statice
        rb.bodyType = RigidbodyType2D.Static;
        // set trigger
        anim.SetTrigger("death");
        // add small delay before changing text
        Invoke("UpdateLives", 0.5f);
    }
    
    // restart level
    private void RestartLevel()
    {
        // go to game over screen if lives are 0
        if (lives <= 0)
        {
            EndGame();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // end game
    private void EndGame()
    {
        SceneManager.LoadScene("End Screen");
    }

    // update lives text
    private void UpdateLives()
    {
        GameObject[] hearts = GameObject.FindGameObjectsWithTag("Heart");
        // disable hearts
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].SetActive(false);
        }
        // enable hearts
        for (int i = 0; i < lives; i++)
        {
            hearts[i].SetActive(true);
        }
    }
}
