using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public int Scenenow;    //o arithmos ths scene einai vasi tou buildSetting
    int Level;
    //public Text LevelText;//Level
    public Text levelText;

     void Update()
     {
        SetLeveltText();
     }

    public void PauseGame()
    {
        PlayerPrefs.SetInt("Scene", Scenenow);
        SceneManager.LoadScene("Pause");
    }

    void SetLeveltText()
    {
        Level = Scenenow - 4;
        levelText.text = Level.ToString();
    }

}
