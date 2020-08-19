using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    string scenetogo;
    string Showit;
    private int attempsM;

    private int English1;
    private int Greek1;
    private int Russian1;

    private int Accept1;

    public void PlayAgain()
    {
        English1 = PlayerPrefs.GetInt("English");
        Greek1 = PlayerPrefs.GetInt("Greek");
        Russian1 = PlayerPrefs.GetInt("Russian");
        Accept1 = PlayerPrefs.GetInt("Accept");

        if (Accept1 == 1 && English1 == 1)
        {
            SceneManager.LoadScene("Menu");
        }
        if (Accept1 == 1 && Greek1 == 1)
        {
            SceneManager.LoadScene("MenuGreek");
        }
        if (Accept1 == 1 && Russian1 == 1)
        {
            SceneManager.LoadScene("MenuRussian");
        }
    }

    public void ResumeGame()
    {
       // scene = PlayerPrefs.GetInt("Scene"); //o arithmos ths scene einai vasi tou buildSetting
      //  SceneManager.LoadScene(scene);
    }

    public void RetryGame()
    {
        attempsM = PlayerPrefs.GetInt("Lives");
        attempsM = attempsM - 1;
        PlayerPrefs.SetInt("Lives", attempsM);
        Showit = PlayerPrefs.GetString("Level");
        scenetogo = PlayerPrefs.GetString("Level"); 
        SceneManager.LoadScene(scenetogo);
        SceneManager.LoadScene(Showit);
    }


}
