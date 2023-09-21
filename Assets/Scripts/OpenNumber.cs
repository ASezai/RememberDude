using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenNumber : MonoBehaviour
{
    Color turnUpNumbers = new Color(1f, 1f, 1f, 1f);

    public static int numbersValue;
    [SerializeField] private int numberValue;

    private void OnMouseDown()
    {

        if (Input.GetMouseButton(0))
        {
            gameObject.GetComponent<SpriteRenderer>().material.SetColor("_Color", turnUpNumbers);
            CheckNumber(numberValue);
        }
    }

    public void CheckNumber(int number)
    {
        for (int i = numbersValue; i < numbersValue + 1; i++)
        {
            if (number == i) // Continue
            {
                gameObject.SetActive(false);
            }
            else if (number != i)  // Game OVer and Restart
            {
                GameManager.TimeStart = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameManager.gameOver = true;
                numbersValue = 0;
            }
            if (number == i && i == 9) // If all numbers are opened correctly, the game ends!!
            {
                GameManager.TimeStart = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameManager.gameSucces = true;
                GameManager.gameOver = false;
                numbersValue = 0;
            }
        }
        numbersValue = numbersValue + 1;
    }
}