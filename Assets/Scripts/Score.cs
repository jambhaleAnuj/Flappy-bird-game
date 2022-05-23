using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public Text playerScore;
    public Text HighScore;
    int scoreCount = 0;
    int highscoreCount;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreCount = PlayerPrefs.GetInt("playerScore", 0);
        highscoreCount = PlayerPrefs.GetInt("HighScore",0);
        if (playerScore == null)
        {
            Destroy(playerScore);
        }
        else
        {
            playerScore.text = "Your Score: " + scoreCount.ToString();
        }


        if (HighScore == null)
        {
            Destroy(HighScore);
        }
        else {
            HighScore.text = "HighScore: " + highscoreCount.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<UnityEngine.UI.Text>() == null)
        {
            Destroy(this);
        }
        else
        {
            GetComponent<UnityEngine.UI.Text>().text = score.ToString();
            PlayerPrefs.SetInt("playerScore", score);
            if (score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        }

    }

    


}
