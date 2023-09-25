using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool IsGameOver = false;
    public static bool IsGameSucces = false;
    public static bool TimeHasStarted = false;
    public static float Timer;

    [SerializeField] private GameObject zero;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private TextMeshProUGUI scoreTimeText;
    [SerializeField] private TextMeshProUGUI timeText;
    
    private void Update()
    {
        if (IsGameOver)
        {
            GameOver();
            zero.SetActive(true);
        }
        else if (!IsGameOver)
        {
            GameHasStarted();
        }
        if (!IsGameOver && IsGameSucces)
        {
            Score();
            zero.SetActive(true);
        }
        if (TimeHasStarted)
        {
            Timer = Timer + Time.deltaTime;
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
    }
    public void Score()
    {
        scoreTimeText.text = Timer.ToString();
        scorePanel.SetActive(true);
    }
}