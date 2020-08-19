using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{

    int AustraliaMAP;
    int AsiaMAP;
    int UsaMAP;
    int AfricaMAP;

    public Button AustraliaButton;
    public Button AsiaButton;
    public Button UsaButton;
    public Button AfricaButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AustraliaMAP = PlayerPrefs.GetInt("AustraliaMAP");
        AsiaMAP = PlayerPrefs.GetInt("AsiaMAP");
        UsaMAP = PlayerPrefs.GetInt("UsaMAP");
        AfricaMAP = PlayerPrefs.GetInt("AfricaMAP");

        if (AustraliaMAP == 1)
            AustraliaButton.interactable = true;
        else
            AustraliaButton.interactable = false;

        if (AsiaMAP == 1)
            AsiaButton.interactable = true;
        else
            AsiaButton.interactable = false;

        if (UsaMAP == 1)
            UsaButton.interactable = true;
        else
            UsaButton.interactable = false;

        if (AfricaMAP == 1)
            AfricaButton.interactable = true;
        else
            AfricaButton.interactable = false;

    }

    public void EuropeSelect()
    {
        SceneManager.LoadScene("EuropeScrollingMap");
        PlayerPrefs.SetInt("Lives", 5);
    }
    public void AustraliaSelect()
    {
        SceneManager.LoadScene("2");
        PlayerPrefs.SetInt("Lives", 5);
    }
    public void AsiaSelect()
    {
        SceneManager.LoadScene("3");
        PlayerPrefs.SetInt("Lives", 5);
    }
    public void UsaSelect()
    {
        SceneManager.LoadScene("4");
        PlayerPrefs.SetInt("Lives", 5);
    }

    public void AfricaSelect()
    {
        SceneManager.LoadScene("5");
        PlayerPrefs.SetInt("Lives", 5);
    }
}
