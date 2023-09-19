using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
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
        deathSound.Play();
        // set statice
        rb.bodyType = RigidbodyType2D.Static;
        // set trigger
        anim.SetTrigger("death");
    }
    
    // restart level
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
