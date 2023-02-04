using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    public int healthMax = 3;

    public int healthCurrent;

    void Start()
    {

        healthCurrent = healthMax;

    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.CompareTag("Bullet"))
        {

            healthCurrent--;

            if (healthCurrent == 0)
            {

                gameObject.SetActive(false);

            }
        }


    }
}
