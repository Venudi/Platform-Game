using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    // strawberry count
    private int strawberries = 0;

    [SerializeField] private Text strawberriesText; // [SerializeField] allows private variables to be edited in Unity inspector
    [SerializeField] private AudioSource collectionSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Strawberry"))
        {
            collectionSound.Play();
            Destroy(collision.gameObject);
            strawberries++;
            strawberriesText.text = ": " + strawberries;
        }
    }
}
