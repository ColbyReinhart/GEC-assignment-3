// Jimmy Vegas Unity Tutorials
// This Script will create your global scripts

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalTimer : MonoBehaviour
{

    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public bool isTakingTime = false;
    public int theSeconds = 150;
    public static int extendScore;

    void Update()
    {
        extendScore = theSeconds;

        if (!isTakingTime)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<TMP_Text>().text = "" + theSeconds;
        timeDisplay02.GetComponent<TMP_Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }

}