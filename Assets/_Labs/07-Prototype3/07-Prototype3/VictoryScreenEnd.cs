using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryScreenEnd : MonoBehaviour
{
    public GameObject VictoryText;
    void Start()
    {
        VictoryText.SetActive(false);
    }

    void OnTriggerEnter (Collider player) 
    {
        if(player.gameObject.tag == "Player")
        {
            VictoryText.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("07-Prototype3");
    }
}
