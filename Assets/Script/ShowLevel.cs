using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowLevel : MonoBehaviour
{
    string Showit;
    public Text Leveltext;

    // Start is called before the first frame update
    void Start()
    {
       Showit = PlayerPrefs.GetString("Level");
        //EDW EINAI TO CHECK GIA TA LEVELS TOU MAP POU THA KANEIS GIA NA KSEKLEIDWNEI TO EPOMENO
         
        if (Showit == "2")
        {
            PlayerPrefs.SetInt ("AustraliaMAP",1 );
        }

        if (Showit == "3")
        {
            PlayerPrefs.SetInt("AsiaMAP", 1);
        }

        if (Showit == "4")
        {
            PlayerPrefs.SetInt("UsaMAP", 1);
        }


        Leveltext.text = Showit.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
