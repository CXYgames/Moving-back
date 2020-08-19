using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneNumber : MonoBehaviour
{

    public string SceneNow;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Level", SceneNow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
