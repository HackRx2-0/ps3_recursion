using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManger : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject pauseMenuPanel;

    void Start()
    {
        pauseButton.SetActive(true);
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void onClick_Pause()
    {
        pauseButton.SetActive(false);
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void onClick_Resume()
    {
        pauseButton.SetActive(true);
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void onClick_MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}