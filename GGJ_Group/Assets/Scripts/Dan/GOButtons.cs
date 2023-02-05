using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOButtons : MonoBehaviour
{
    public void TryAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);        
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
