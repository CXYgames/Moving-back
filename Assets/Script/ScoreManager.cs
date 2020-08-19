using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
<<<<<<< Updated upstream
    static int score=0;
=======
    static int score;
    int scoreshow;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        if (instance==null)
        {
            instance = this;
        }
        //Deixnei to score sthn epomenh scene xwris na grafei 0
        text.text = "X" + score.ToString();
    }

    // Update is called once per frame
    public void ChangeScore(int coinValue)
    {
        score = score+ coinValue;
<<<<<<< Updated upstream
        text.text = "X" + score.ToString(); //SOU deixnei to score meta to X
=======
        PlayerPrefs.SetInt("Score", score);
        scoreshow = score;
        text.text = "X" + scoreshow.ToString(); //SOU deixnei to score meta to X
>>>>>>> Stashed changes
    }
    void Update()
    {
        //text.text = ScoreManager.ToString();
    }
}
