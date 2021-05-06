using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class WaterAudio : MonoBehaviour
{
    public AudioClip splashSound;
    public AudioClip Ambiance;
    public AudioClip VictorySound;
    public AudioClip Track2_Aux;

    public AudioSource audioS;

    private void Update()
    {

    }

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
        if (other.CompareTag("Finish"))
        {
            audioS.PlayOneShot(VictorySound);
        }
        if (other.CompareTag("Enemy"))
        {
            audioS.PlayOneShot(Track2_Aux);
        };
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        
    }
}
