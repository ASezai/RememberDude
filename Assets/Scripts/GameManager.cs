using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool gameSucces = false;

    private string score;

    public GameObject gameOverPanel;
    public GameObject scorePanel;

    public TextMeshProUGUI scoreTimeText;
    private void Update()
    {
        if (gameOver)
        {
            GameOver();
        }
        else if (!gameOver)
        {
            GameHasStarted();
        }
        if (!gameOver && gameSucces)
        {
            Score();
        }
    }
    public void GameHasStarted()
    {
        gameOverPanel.SetActive(false);
        scorePanel.SetActive(false);
        //gameStarted = false;
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        //gameOver = false;
    }
    public void Score()
    {
        score = Timer.time.ToString();
        scoreTimeText.text = score;
        scorePanel.SetActive(true);
    }
}
