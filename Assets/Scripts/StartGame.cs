using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartGame : MonoBehaviour
{
    public static int turnDownNumbers = 0;
    private void OnMouseDown()
    {
        //GameObject[] allObjects = GameObject.FindGameObjectsWithTag("Numbers");
        if (Input.GetKey("mouse 0"))
        {
            turnDownNumbers = 1;
            gameObject.SetActive(false);
        }
    }
}
