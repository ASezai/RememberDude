using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static int gameOver = 0;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (gameOver == 1)
        {
            gameObject.SetActive(true);
        }
    }
}
