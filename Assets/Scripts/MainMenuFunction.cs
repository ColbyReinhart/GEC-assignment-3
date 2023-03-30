using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    public GameObject bestScoreDisplay;

    private void Start()
    {
        bestScoreDisplay.GetComponent<TMP_Text>().text = "BEST: " + PlayerPrefs.GetInt("LevelScore");
    }

    public void PlayGame()
    {
        buttonPress.Play();
        SceneManager.LoadScene("Scenes/RedirectLevel");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCreds()
    {
        buttonPress.Play();
        SceneManager.LoadScene("Scenes/Credits");
    }

    public void ResetBest()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
    }
}