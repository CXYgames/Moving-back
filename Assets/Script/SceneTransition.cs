using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
<<<<<<< Updated upstream
=======
    private int attemps;

    public float delaytime = 2f;
    //public Text ScoreShow;
    private int totalScore;
    private int Score;
    private int Scoretime;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")&& !other.isTrigger)
        {
<<<<<<< Updated upstream
            SceneManager.LoadScene(sceneToLoad);
        }
    }
=======
            Scoring();
            givealife();
            SceneManager.LoadScene(sceneToLoad);

            //Invoke("MoveToScene", 2f);
           // StartCoroutine(Delayshower(sceneToLoad));

            PlayerPrefs.SetInt("Level", 1); // to thelw?


            //Debug.Log(PlayerPrefs.GetFloat("Time").ToString());
        }
    }
    IEnumerator Delayshower(string sceneToLoad)
    {
        yield return new WaitForSeconds(delaytime);
        SceneManager.LoadScene(sceneToLoad);
    }
    public void MoveToScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }


    public void givealife()
    {
        attemps = PlayerPrefs.GetInt("Lives");
        attemps = attemps + 1;
        PlayerPrefs.SetInt("Lives", attemps);
    }



    void Scoring()
    {

        Scoretime = PlayerPrefs.GetInt("Time");
        Score = PlayerPrefs.GetInt("Score");
        totalScore = Score + Scoretime;

        PlayerPrefs.SetInt("Score", totalScore); //me auto ti ginete


       // totalScore = totalScore + Score;
       // ScoreShow.text = totalScore.ToString();

    }
>>>>>>> Stashed changes
}
