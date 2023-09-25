using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool IsGameOver = false;
    public static bool IsGameSuccess = false;
    public static bool TimeHasStarted = false;
    public static float Timer = 1;
    public static int LevelNumberCount { get; private set; } = 9 ;

    [SerializeField] private GameObject zero;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private TextMeshProUGUI scoreTimeText;
    [SerializeField] private TextMeshProUGUI timeText;


    private void Update()
    {
        if (IsGameOver || Timer <= 0)
        {
            GameOver();
            zero.SetActive(true);
        }
        else if (!IsGameOver)
        {
            GameHasStarted();
        }
        if (!IsGameOver && IsGameSuccess)
        {
            Score();
            zero.SetActive(true);
        }
        if (TimeHasStarted)
        {
            Timer = Timer - Time.deltaTime;
            timeText.text = Timer.ToString("0.00");
        }
    }
    public void GameHasStarted()
    {
        gameOverPanel.SetActive(false);
        scorePanel.SetActive(false);
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        IsGameOver = true;
        TimeHasStarted = false;
        LevelNumberCount = 9;
    }
    public void Score()
    {
        IsGameSuccess = false;
        scoreTimeText.text = Timer.ToString();
        scorePanel.SetActive(true);
        LevelNumberCount = LevelNumberCount + 2;
    }
}