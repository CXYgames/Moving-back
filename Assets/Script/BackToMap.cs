using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMap : MonoBehaviour
{
    public void Backmap()
    {
        SceneManager.LoadScene("Map");

    }

}
