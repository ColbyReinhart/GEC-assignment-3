using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    void Update()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }
}