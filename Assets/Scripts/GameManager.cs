using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject gameManagerObject = new GameObject("GameManager");
                    instance = gameManagerObject.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    public bool IsGameOver { get; private set; } = false;
    public bool IsGameSuccess { private get; set; } = false;
    public bool TimeHasStarted { private get; set; } = false;
    public float Timer { private get; set; } = 1;
    public int LevelNumberCount { get; private set; } = 9;
    public float ExtraTime { get; private set; } = 13f;

    [SerializeField] private GameObject zero;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private TextMeshProUGUI scoreTimeText;
    [SerializeField] private TextMeshProUGUI timeText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (TimeHasStarted)
        {
            Timer -= Time.deltaTime;
            timeText.text = Timer.ToString("0.00");
            if (Timer <= 0)
            {
                GameOver();
            }
        }
    }

    public void GameHasStarted()
    {
        gameOverPanel.SetActive(false);
        scorePanel.SetActive(false);
        IsGameOver = false;
        IsGameSuccess = false;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        IsGameOver = true;
        TimeHasStarted = false;
        LevelNumberCount = 9;
        ExtraTime = 13f;
        zero.SetActive(true);
    }

    public void Score()
    {
        IsGameSuccess = false;
        scoreTimeText.text = Timer.ToString();
        scorePanel.SetActive(true);
        LevelNumberCount += 1;
        ExtraTime += (Timer + 1);
        zero.SetActive(true);
    }
}
