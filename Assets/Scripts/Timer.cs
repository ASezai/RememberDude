using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI TimeText;
    public static int TimeStart = 0;
    public static float time;

    private void Update()
    {
        if (TimeStart == 1)
        {
            time = time + Time.deltaTime;
            TimeText.text = time.ToString("0.00");
        }
    }
}
