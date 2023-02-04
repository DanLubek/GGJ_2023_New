using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{


    public GameObject enemyPrefab;
    public int poolSize;
    public Dictionary<GameObject, bool> pool = new Dictionary<GameObject, bool>();
    public Transform[] spawnPosition;
    int randomSpawnPoint;
    public Transform tempPosition;

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = (GameObject)Instantiate(enemyPrefab, tempPosition.position, Quaternion.identity);

            pool.Add(obj, true);

            obj.SetActive(false);
        }
    }

    public void SpawnPrefab()
    {

        randomSpawnPoint = Random.Range(0, spawnPosition.Length);



        foreach (KeyValuePair<GameObject, bool> obj in pool)
        {
            if (obj.Value == true)
            {
                enemyPrefab = obj.Key;
                break;
            }
        }

        pool[enemyPrefab] = false;

        enemyPrefab.SetActive(true);

        enemyPrefab.transform.position = spawnPosition[randomSpawnPoint].position;

        StartCoroutine(ReturnPrefab(enemyPrefab));
    }




    IEnumerator ReturnPrefab(GameObject selPrefab)
    {



        yield return new WaitForSeconds(30.0f);
        selPrefab.transform.position = tempPosition.position;
        selPrefab.SetActive(false);
        selPrefab.GetComponent<Rigidbody>().velocity = Vector3.zero;

        pool[selPrefab] = true;

    }


}
