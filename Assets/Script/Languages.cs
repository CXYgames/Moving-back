using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Languages : MonoBehaviour
{
    

    void Start()    //Vazei 0 apo thn arxi giati miniskei MONO to russian|| ota tha mpei sto thlefwno na fugei LOGIKA tha minei arxikh epilgh
    {

        
        

    }
    public void English()
    {
        
        SceneManager.LoadScene("Terms");
        PlayerPrefs.SetInt("English", 1);
        PlayerPrefs.SetInt("Accept", 0);
    }

    public void Greek()
    {

        SceneManager.LoadScene("Terms");
        PlayerPrefs.SetInt("Greek", 1);
        PlayerPrefs.SetInt("Accept", 0);
    }


    public void Russian()
    {

        SceneManager.LoadScene("Terms");
        PlayerPrefs.SetInt("Russian", 1);
        PlayerPrefs.SetInt("Accept", 0);
    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
