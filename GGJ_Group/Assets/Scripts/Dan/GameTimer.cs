using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public static float timeValue, minutes, seconds;
    private TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        timeValue = 0;
        timer = GetComponent<TextMeshProUGUI>();
        timer.text = minutes.ToString() + " : " + seconds.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeValue += Time.deltaTime;

        minutes = Mathf.FloorToInt(timeValue / 60);
        seconds = Mathf.FloorToInt(timeValue % 60);

        if (seconds < 10)
        {
            timer.text = "Time survived: " + "0" + minutes.ToString() + " : 0" + seconds.ToString();
        }
        else
        {
            timer.text = "Time survived: " + "0" + minutes.ToString() + " : " + seconds.ToString();
        }
    }
}
