using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverScreen, IGUI;
    public TextMeshProUGUI killDisplay, timeDisplay;

    private void Update()
    {
        if (PlayerHealth.gameOver == true)
        {
            IGUI.SetActive(false);
            gameOverScreen.SetActive(true);
            killDisplay.text = "Killed " + DestroyEnemy.killCount.ToString() + " mushrooms";
            timeDisplay.text = "Survival time: " + GameTimer.minutes.ToString() + ":" + GameTimer.seconds.ToString();
        }
    }
}
