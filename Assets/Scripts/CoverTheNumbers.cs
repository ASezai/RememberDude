using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverTheNumbers : MonoBehaviour
{
    Color CoverUpColor = new Color(0f, 0f, 0f, 1f);
    private void Update()
    {
        if (OpenNumber.GameHasStarted == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().material.SetColor("_Color", CoverUpColor);
        }
    }
}