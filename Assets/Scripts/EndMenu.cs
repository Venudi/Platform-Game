using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    // quit button serializable field
    [SerializeField] private GameObject quitButton;
    // restart button serializable field
    [SerializeField] private GameObject restartButton;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    private void Update()
    {
        // // if game object restartButton is pressed
        // if (restartButton.isPressed)
        // {
        //     // restart game
        //     RestartGame();
        // }
        // // if game object quitButton is pressed
        // if (quitButton.isPressed)
        // {
        //     // quit game
        //     QuitGame();
        // }
    }

}
