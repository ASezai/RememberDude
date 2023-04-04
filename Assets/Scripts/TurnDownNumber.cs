using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnDownNumber : MonoBehaviour
{
    private static int turnDownControl;

    Color backColor = new Color(0f, 0f, 0f, 1f);

    private void Update()
    {
        turnDownControl = StartGame.turnDownNumbers;
        if (turnDownControl == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().material.SetColor("_Color", backColor);
        }
    }
}
