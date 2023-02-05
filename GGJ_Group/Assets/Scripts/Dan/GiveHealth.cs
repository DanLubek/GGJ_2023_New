using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GiveHealth : MonoBehaviour
{
    bool canHeal;
    float distance;
    public GameObject player;
    float detectionDistance;

    public GameObject gainedHealth;


    private void Start()
    {
        canHeal = true;
        detectionDistance = 30f;
    }

    private void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance <= detectionDistance && canHeal)
        {
            if (PlayerHealth.curHealth != 1)
            {
                PlayerHealth.GiveMaxHealth();
                HealthBars.MaxPlayerHealth();
                gainedHealth.SetActive(true);
                StartCoroutine(TextDisplayCountdown());
                canHeal = false;
                StartCoroutine(HealDelay());
            }
        }
    }

    IEnumerator HealDelay()
    {
        yield return new WaitForSeconds(8f);
        canHeal = true;
    }

    IEnumerator TextDisplayCountdown()
    {
        yield return new WaitForSeconds(2f);
        gainedHealth.SetActive(false);
    }
}
