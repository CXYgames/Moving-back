using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
<<<<<<< Updated upstream
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
=======

    public void PlayGame()
    {
        PlayerPrefs.SetInt("Lives", 5);
        PlayerPrefs.GetInt("Animal");
        Debug.Log(PlayerPrefs.GetInt("Animal").ToString());
        Debug.Log(PlayerPrefs.GetInt("Lives").ToString());
        SceneManager.LoadScene("1");
    }

    public void Shop()
    {
        SceneManager.LoadScene("Shop");
>>>>>>> Stashed changes
    }

    public void MoveToMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
