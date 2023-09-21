using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool gameSucces = false;

    public GameObject gameOverPanel;
    public GameObject scorePanel;

    public TextMeshProUGUI scoreTimeText;

    public TextMeshProUGUI TimeText;
    public static int TimeStart = 0;
    public static float time;
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
        if (TimeStart == 1)
        {
            time = time + Time.deltaTime;
            TimeText.text = time.ToString("0.00");
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
        scoreTimeText.text = time.ToString();
        scorePanel.SetActive(true);
    }
}