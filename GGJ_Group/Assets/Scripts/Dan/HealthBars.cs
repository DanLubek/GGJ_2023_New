using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBars : MonoBehaviour
{
    static private Image treeHealthImage, playerHealthImage;
    static private GameObject healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GameObject.Find("TreeHealthBar");
        treeHealthImage = GameObject.Find("TreeBarImage").GetComponent<Image>();
        treeHealthImage.fillAmount = 1;
        playerHealthImage = GameObject.Find("PlayerBarImage").GetComponent<Image>();
        playerHealthImage.fillAmount = 1;
    }

    public static void UpdateTreeHealth(float dmgDone)
    {
        treeHealthImage.fillAmount -= dmgDone;
    }

    public static void HideTreeHealth()
    {
        healthBar.SetActive(false);
    }

    public static void UpdatePlayerHealth(float dmgDone)
    {
        playerHealthImage.fillAmount -= dmgDone;
    }

    public static void MaxPlayerHealth()
    {
        playerHealthImage.fillAmount = 1;
    }
}
