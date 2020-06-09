using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class Timer : MonoBehaviour
{
    public string sceneToLoad;
    public float timer = 10f;
    private Text timerSeconds;
    private int Timeout;

    // Use this for initialization
    void Start()
    {
        timerSeconds = GetComponent<Text>();
        Timeout = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; 
        timerSeconds.text = timer.ToString("f1"); //posa dekadika na deixnei
        if (timer <= 0)
        {
            //SceneManager.LoadScene(sceneToLoad); //se pia skinh na se pernei
            Timeout = 1;
        }

    }
}
