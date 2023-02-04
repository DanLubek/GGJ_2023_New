using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public static bool spawnAllowed;
    public ObjectPooler OP;
    public float randomTime;

    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnEnemies", 0f, randomTime);
    }

    void SpawnEnemies()
    {
        if (spawnAllowed)
        {
            OP.SpawnPrefab();
        }
    }

}
