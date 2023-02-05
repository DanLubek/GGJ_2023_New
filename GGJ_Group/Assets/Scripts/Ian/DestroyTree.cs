using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTree : MonoBehaviour
{
    public float healthMax = 1;
    public float healthCurrent;
    private float damage;

    void Start()
    {
        damage = 0.1f;
        healthCurrent = healthMax;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.collider.CompareTag("Enemy"))
        {
            healthCurrent -= damage;
            HealthBars.UpdateTreeHealth(damage);

            if (healthCurrent <= 0)
            {
                HealthBars.HideTreeHealth();
                Destroy(gameObject);
            }
        }
    }
}
