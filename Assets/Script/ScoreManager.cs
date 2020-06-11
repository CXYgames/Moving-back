using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    static int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance==null)
        {
            instance = this;
        }
        //Deixnei to score sthn epomenh scene xwris na grafei 0
        score = PlayerPrefs.GetInt("Score");
        text.text = "X" + score.ToString();
    }

    // Update is called once per frame
    public void ChangeScore(int coinValue)
    {
        score = score+ coinValue;
        PlayerPrefs.SetInt("Score", score);
        text.text = "X" + score.ToString(); //SOU deixnei to score meta to X
    }
    void Update()
    {
        //text.text = ScoreManager.ToString();
    }
}
