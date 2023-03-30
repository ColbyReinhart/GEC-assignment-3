using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool paused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pauseJingle;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!paused)
            {
                pauseJingle.Play();
                Time.timeScale = 0.0f;
                paused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void RestartLevel()
    {
        ResumeGame();
        SceneManager.LoadScene("Scenes/RedirectLevel");
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = true;
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        paused = false;
        Cursor.visible = false;
        levelMusic.UnPause();
        pauseMenu.SetActive(false);
    }
}
