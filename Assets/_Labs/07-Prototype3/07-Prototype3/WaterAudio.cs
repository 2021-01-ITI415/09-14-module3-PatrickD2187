using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class WaterAudio : MonoBehaviour
{
    public AudioClip splashSound;
    public AudioClip Ambiance;

    public AudioSource audioS;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("Ambience"))
        {
            audioS.PlayOneShot(Ambiance);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        
    }
}
