using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public static int killCount;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            killCount++;
            Debug.Log(killCount);
            gameObject.SetActive(false);            
        }
    }
}
