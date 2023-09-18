using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    // strawberry count
    private int strawberries = 0;

    [SerializeField] private Text strawberriesText; // [SerializeField] allows private variables to be edited in Unity inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Strawberry"))
        {
            Destroy(collision.gameObject);
            strawberries++;
            strawberriesText.text = "Strawberries: " + strawberries;
        }
    }
}
