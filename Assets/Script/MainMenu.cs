using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        PlayerPrefs.SetInt("Lives", 3);
        PlayerPrefs.SetInt("Score", 0);
        Debug.Log(PlayerPrefs.GetInt("Lives").ToString());
        SceneManager.LoadScene("Level1");

    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
