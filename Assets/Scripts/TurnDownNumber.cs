using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnDownNumber : MonoBehaviour
{
    Color backColor = new Color(0f, 0f, 0f, 1f);
    private void Update()
    {
        if (StartGame.turnDownNumbers == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().material.SetColor("_Color", backColor);
        }
    }
}
