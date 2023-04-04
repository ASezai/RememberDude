using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNumbers : MonoBehaviour
{
    private const int MiNX = -2;
    private const int MAXX = 2;
    private const int MiNY = -4;
    private const int MAXY = 4;

    private int posX;
    private int posY;
    private int numberCount = 0;
    private Vector2 spawnPosition;

    public int[,] positionList = new int[9,2];
    public List<GameObject> Numbers;

    //public GameManager GameManager; // NullReferenceMistake-The code is not working

    private void OnMouseDown()
    {
        if (Input.GetKey ("mouse 0"))
        {
            //GameManager.GameHasStarted(); // NullREferenceMistake-The code is not working
            GameManager.gameOver = false;
            GameManager.gameSucces = false;
            StartGame.turnDownNumbers = 0;
            OpenNumber.numbersValue = 2;
            Timer.timeStart = 1;
            Timer.time = 0;
            
            gameObject.SetActive(false);
            for (int i = 0; i < Numbers.Count; i++)
            {
                spawnPosition = PositionProducer();
                numberCount++;
                Instantiate(Numbers[i], spawnPosition, Quaternion.identity); // Spawn in generated random location
            }
        }
    }

    //Generates a new position value different from previous values
    public Vector2 PositionProducer()
    {
        int numberPositionCount = numberCount; // Count of generated positions for numbers
        int numbCountList = numberCount; // Numbers count for list
        int numbPosList = 0;             // Position values of numbers

        Vector2 nexPosition;

        posX = Random.Range(MiNX, MAXX);
        posY = Random.Range(MiNY, MAXY);

        positionList[numbCountList, numbPosList] = posX;
        positionList[numbCountList, numbPosList + 1] = posY;

        while(numberPositionCount > 0)
        {
            if (positionList[numbCountList, numbPosList] == positionList[numberPositionCount - 1, numbPosList] && 
                positionList[numbCountList, numbPosList + 1] == positionList[numberPositionCount - 1, numbPosList + 1])
            {
                posX = Random.Range(MiNX, MAXX);
                posY = Random.Range(MiNY, MAXY);
                positionList[numbCountList, numbPosList] = posX;
                positionList[numbCountList, numbPosList + 1] = posY;
            }
            else
            {
                numberPositionCount--;
            }
        }
        nexPosition = new Vector2(posX, posY);
        return nexPosition;
    }
}
