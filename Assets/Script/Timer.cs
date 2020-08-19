using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class Timer : MonoBehaviour
{
    public string sceneToLoad;
    public float timer ;
    private int attempsM;

    private Text timerSeconds;
    
    // Use this for initialization
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer- Time.deltaTime; 
        timerSeconds.text = timer.ToString("f1"); //posa dekadika na deixnei

        if (timer <= 0)
        {
        //  attempsM = PlayerPrefs.GetInt("Lives");
        //  attempsM = attempsM - 1;
        //   PlayerPrefs.SetInt("Lives", attempsM);

        // SceneManager.LoadScene(sceneToLoad); //se pia skinh na se pernei 
        }
    }
}
