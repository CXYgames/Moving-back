﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DentedPixel;

public class Bar : MonoBehaviour
{

    public GameObject bar;
    public int time;

    private int English1;
    private int Greek1;
    private int Russian1;


    private int Accept1;

    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time).setOnComplete(MovetoNext);
    }

    public void MovetoNext()
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


        if (Accept1 == 0)
        {
            SceneManager.LoadScene("Languages");
        }
    }
}
