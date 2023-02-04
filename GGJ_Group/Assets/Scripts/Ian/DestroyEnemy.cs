using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    public int healthMax = 1;

    public int healthCurrent;

    void Start()
    {

        healthCurrent = healthMax;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
        }
    }
}
