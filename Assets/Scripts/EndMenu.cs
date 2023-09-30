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
        PlayerLife.lives = 5;
        PlayerLife.strawberriesGlobal = 0;
        Application.Quit();
    }

    public void RestartGame()
    {
        PlayerLife.lives = 5;
        PlayerLife.strawberriesGlobal = 0;
        SceneManager.LoadScene("Level 0");
    }

    public void BackToMenu()
    {
        PlayerLife.lives = 5;
        PlayerLife.strawberriesGlobal = 0;
        SceneManager.LoadScene("Start Screen");
    }

}
