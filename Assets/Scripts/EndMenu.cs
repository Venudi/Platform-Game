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
        SceneManager.LoadScene("Level 0");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }

}
