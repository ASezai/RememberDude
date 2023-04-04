using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenNumber : MonoBehaviour
{
    Color turnUpNumbers = new Color(1f, 1f, 1f, 1f);

    private string numberStrName;
    private int number;

    public static int numbersValue=2;
    //public GameManager GameManager; // NullReferenceMistake-The code is not working

    private void OnMouseDown()
    {
        
        if (Input.GetKey("mouse 0"))
        {
            gameObject.GetComponent<SpriteRenderer>().material.SetColor("_Color", turnUpNumbers);
            numberStrName = gameObject.tag;
            int.TryParse(numberStrName, out number);
            RemoveList(number);
        }
    }

    public void RemoveList(int number)
    {
        for (int i = numbersValue; i < numbersValue + 1; i++)
        {
            if (number == i) // Continue
            {
                //Debug.Log("True");
                gameObject.SetActive(false);
            }
            else if(number != i)  // Game OVer and Restart
            {
                //Debug.Log("Game Over");
                //GameManager.GameOver(); // NullReferenceMistake-The code is not working
                Timer.timeStart = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameManager.gameOver = true;
            }
            if (number == i && i == 9) // If all numbers are opened correctly, the game ends!!
            {
                //Debug.Log("Succes");
                Timer.timeStart = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameManager.gameSucces = true;
                GameManager.gameOver = false;
            }
        }
        numbersValue = numbersValue + 1;
    }
}
