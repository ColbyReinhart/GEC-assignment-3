// Jimmy Vegas Unity Tutorials
// This Script will collect your first gem

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GemSilver : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioClip collectSound;
    public float collectSoundVolume = 0.5f;

    void OnTriggerEnter()
    {
        scoreBox.GetComponent<TMP_Text>().text = "1000";
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(collectSound, transform.position, collectSoundVolume);
    }
}