using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public static int GameHasStarted = 0;

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            OpenNumber.SearchedNumber = 2;
            GameHasStarted = 1;
            gameObject.SetActive(false);
        }
    }
}