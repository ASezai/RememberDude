using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNumbers : MonoBehaviour
{
    private const int MiNX = -2;
    private const int MAXX = 2;
    private const int MiNY = -4;
    private const int MAXY = 4;

    private List<Vector2> availablePositions = new List<Vector2>();
    private Vector2 spawnPosition;

    [SerializeField] private List<GameObject> Numbers;

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            FillPositions();
            
            OpenNumber.GameHasStarted = 0;

            GameManager.Instance.GameHasStarted();
            GameManager.Instance.TimeHasStarted = true;
            GameManager.Instance.Timer = GameManager.Instance.ExtraTime;

            gameObject.SetActive(false);

            for (int i = 0; i < GameManager.Instance.LevelNumberCount; i++)
            {
                spawnPosition = GetRandomPosition();
                Instantiate(Numbers[i], spawnPosition, Quaternion.identity);
            }
        }
    }

    //Generates a new position value different from previous values
    private Vector2 GetRandomPosition()
    {
        if (availablePositions.Count == 0)
        {
            return Vector2.zero;
        }

        int randomIndex = Random.Range(0, availablePositions.Count);
        Vector2 randomPosition = availablePositions[randomIndex];
        availablePositions.RemoveAt(randomIndex); // Kullanlan pozisyonu çkar

        return randomPosition;
    }

    private void FillPositions()
    {
        availablePositions.Clear(); // Önceki pozisyonlarý temizle

        for (float x = MiNX; x <= MAXX; x++)
        {
            for (float y = MiNY; y <= MAXY; y++)
            {
                availablePositions.Add(new Vector2(x, y));
            }
        }
    }
}