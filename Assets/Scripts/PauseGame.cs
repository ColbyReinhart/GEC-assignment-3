using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool paused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!paused)
            {
                Time.timeScale = 0.0f;
                paused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1.0f;
                paused = false;
                Cursor.visible = false;
                levelMusic.UnPause();
                pauseMenu.SetActive(false);
            }
        }
    }
}
