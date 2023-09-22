using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    // player lives
    public int lives = 5;
    [SerializeField] private Text livesText;

    // rigid body 2d
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource deathSound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
        livesText.text = ": " + lives;
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
}
