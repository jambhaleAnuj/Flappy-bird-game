using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject offScore;

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {

        gameOverCanvas.SetActive(true);
        offScore.SetActive(false);
        Destroy(offScore);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
}
