using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // go to main menu
    public void RestartGame()
    {
        // SceneManager.LoadScene("Game");
        // console log current scene name
        Debug.Log("Current scene name: " + SceneManager.GetActiveScene().name);
    }
}