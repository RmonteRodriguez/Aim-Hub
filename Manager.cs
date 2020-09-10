using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
       SceneManager.LoadScene(0); 
    }

    public void FifteenClose()
    {
        SceneManager.LoadScene(1);
    }

    public void FifteenMedium()
    {
        SceneManager.LoadScene(2);
    }

    public void FifteenFar()
    {
        SceneManager.LoadScene(3);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
