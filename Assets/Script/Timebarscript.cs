using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timebarscript : MonoBehaviour
{
    private int time;
    private int Score;
    private int totalScore;
    private int attempsM;
    public string sceneToLoad;

    public Text timer;


    void Start()
    {
        time = 21;
        InvokeRepeating("IncrimentTime", 1, 1);
    }
    void IncrimentTime()
    {
        time = time - 1;
        timer.text = "Time: " + time;
    }

    void Update()
    {
        //IT IS WORKING RIGHT

         if (time <= 0)
         {
          SceneManager.LoadScene(sceneToLoad); //se pia skinh na se pernei
         }

        PlayerPrefs.SetInt("Time", time);
    }
  

    void Scoring()
    {
        if (time > 0 && time < 5)
        {
            Score = time;
        }
        if (time > 4 && time < 8)
        {
            Score = time * 2;
        }
        if (time > 7 && time < 10)
        {
            Score = time * 3;
        }

        
        totalScore = totalScore + Score;
      //  PlayerPrefs.SetInt("Score", totalScore);
    }
}