using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    static int curHealth;
    static int maxHealth;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 50;
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            AddHealth(5);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            RemoveHealth(5);
        }

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

    

    }

    public static void AddHealth(int healthToAdd)
    {
        curHealth += healthToAdd;
    }

    public static void RemoveHealth(int healthToRemove)
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
            RemoveHealth(5);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 200), curHealth.ToString());
    }
  

}
