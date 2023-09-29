using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    // strawberry count
    private int strawberries = 0;

    // global strawberry count
    public static int globalStrawberries = 0;

    [SerializeField] private Text strawberriesText;
    [SerializeField] private AudioSource collectionSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Strawberry"))
        {
            collectionSound.Play();
            Destroy(collision.gameObject);
            strawberries++;
            globalStrawberries++;
            strawberriesText.text = ": " + strawberries;
        }
    }
}
