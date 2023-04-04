using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timeText;
    public static int timeStart = 0;

    public static float time;

    private void Update()
    {
        if (timeStart == 1)
        {
            time = time + Time.deltaTime;
            timeText.text = time.ToString("0.00");
        }
    }
}
