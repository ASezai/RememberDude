using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartGame : MonoBehaviour
{
    public static int turnDownNumbers = 0;
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            OpenNumber.numbersValue = 2;
            turnDownNumbers = 1;
            gameObject.SetActive(false);
        }
    }
}
