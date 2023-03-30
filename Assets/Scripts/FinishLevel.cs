using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject movementBlocker;
    public GameObject fadeOut;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;

    public int nextLevel = 2;

    void OnTriggerEnter()
    {
        movementBlocker.SetActive(true);
        movementBlocker.transform.parent = null;
        timeLeft.GetComponent<TMP_Text>().text = "Time left: " + GlobalTimer.extendScore + " x 100";
        theScore.GetComponent<TMP_Text>().text = "Score: " + GlobalScore.currentScore;
        int timeCalc = GlobalTimer.extendScore * 100;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<TMP_Text>().text = "Total score: " + totalScored;
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        GlobalScore.currentScore = 0;
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scenes/Level" + nextLevel);
    }
}