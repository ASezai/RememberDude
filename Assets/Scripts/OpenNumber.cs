using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenNumber : MonoBehaviour
{
    Color UncoverColor = new Color(1f, 1f, 1f, 1f);

    [SerializeField] private int clickedNumber;

    public static int SearchedNumber = 1;
    public static int GameHasStarted = 0;

    private void Update()
    {
        if (GameManager.Instance.IsGameOver)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            gameObject.GetComponent<SpriteRenderer>().material.SetColor("_Color", UncoverColor);
            CheckNumber(clickedNumber);
            GameHasStarted = 1;
        }
    }

    public void CheckNumber(int ClickedNumber)
    {
        if (ClickedNumber == SearchedNumber) // Continue
        {
            Destroy(gameObject);
        }
        else if (ClickedNumber != SearchedNumber)  // Game Over and Restart
        {
            GameManager.Instance.TimeHasStarted = false;
            GameManager.Instance.GameOver();
            SearchedNumber = 0;
        }
        if (ClickedNumber == SearchedNumber && SearchedNumber == GameManager.Instance.LevelNumberCount) // If all numbers are opened correctly, the game ends
        {
            GameManager.Instance.TimeHasStarted = false;
            GameManager.Instance.Score();
            SearchedNumber = 0;
        }
        SearchedNumber = SearchedNumber + 1;
    }
}