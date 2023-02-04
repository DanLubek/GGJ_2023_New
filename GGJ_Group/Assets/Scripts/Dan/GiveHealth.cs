using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveHealth : MonoBehaviour
{
    bool canHeal;
    float distance;
    public GameObject player;
    float detectionDistance;

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
            PlayerHealth.GiveMaxHealth();
            canHeal = false;
            StartCoroutine(HealDelay());
        }
    }

    IEnumerator HealDelay()
    {
        yield return new WaitForSeconds(8f);
        canHeal = true;
    }
}
