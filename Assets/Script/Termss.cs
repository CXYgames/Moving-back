
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Termss : MonoBehaviour
{
    int Accept;
    int English;
    int Greek;
    int Russian;

    void Update()
    {
    //    PlayerPrefs.SetInt("Accept",0); //eksarxhs dinei 0
        Accept = PlayerPrefs.GetInt("Accept");
        English= PlayerPrefs.GetInt("English");
        Greek= PlayerPrefs.GetInt("Greek");
        Russian = PlayerPrefs.GetInt("Russian");
    }
        public void PlayGame()
    {
        if (Accept == 1 && English==1)
        {
            SceneManager.LoadScene("Menu");
        }

        if (Accept == 1 && Greek == 1)
        {
            SceneManager.LoadScene("Menu");
        }

        if (Accept == 1 && Russian == 1)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void QuitScene()
    {
        Debug.Log("Back to Languages Scene!");
        SceneManager.LoadScene("Languages");
    }

    public void AcceptButton()
    {
        PlayerPrefs.SetInt("Accept", 1);
        Debug.Log(PlayerPrefs.GetInt("Accept").ToString());
    }
}
