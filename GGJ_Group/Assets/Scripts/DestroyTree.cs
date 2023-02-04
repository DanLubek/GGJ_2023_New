using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTree : MonoBehaviour
{
    public int healthMax = 3;

    public int healthCurrent;

    void Start()
    {

        healthCurrent = healthMax;

    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.collider.CompareTag("Enemy"))
        {

            healthCurrent--;

            if (healthCurrent == 0)
            {
                Destroy(gameObject);
            }


        }

    }

}
