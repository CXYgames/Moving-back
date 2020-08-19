using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restar : MonoBehaviour
{
    public string sceneToLoad;
    private int attempsM;

    // Start is called before the first frame update
    public void RestartGame()
    {
        attempsM = PlayerPrefs.GetInt("Lives");
        attempsM = attempsM - 1;
        PlayerPrefs.SetInt("Lives", attempsM);
        SceneManager.LoadScene(sceneToLoad);
    }
}
