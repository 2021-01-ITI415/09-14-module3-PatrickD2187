using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject VictoryText;
    public static int theScore;


    void Start()
    {
        VictoryText.SetActive(false);

    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;

        if (theScore == 3000)
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
