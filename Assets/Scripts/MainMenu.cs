using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void Start()
    {
        // put weird menu script here if broken
        SceneManager.UnloadSceneAsync("WinScreen");
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("ConnorScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
