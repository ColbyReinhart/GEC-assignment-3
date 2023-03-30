// Jimmy Vegas Unity Tutorials
// This Script will collect your first gem

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GreenGem : MonoBehaviour
{
    public AudioClip collectSound;
    public float collectSoundVolume = 0.5f;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 500;
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(collectSound, transform.position, collectSoundVolume);
    }
}