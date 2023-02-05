using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public static float curHealth;
    static float maxHealth;

    public static bool gameOver;
    void Awake()
    {
        gameOver = false;
        maxHealth = 1;
        curHealth = maxHealth;        
    }
    
    void Update()
    {
        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if (gameOver == true) Debug.Log("a");
    }

    public static void AddHealth(int healthToAdd)
    {
        curHealth += healthToAdd;
    }

    public static void RemoveHealth(float healthToRemove)
    {
        curHealth -= healthToRemove;
    }

    public static void GiveMaxHealth()
    {
        curHealth = maxHealth;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            RemoveHealth(0.2f);
            HealthBars.UpdatePlayerHealth(0.2f);

            if (curHealth <= 0.1f)
            {
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                gameOver = true;
            }
        }
    }

    //private void OnGUI()
    //{
    //    GUI.Label(new Rect(10, 10, 200, 200), curHealth.ToString());
    //}
}
