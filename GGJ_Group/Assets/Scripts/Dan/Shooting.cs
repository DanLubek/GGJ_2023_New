using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject spikePrefab, spawnPoint;

    bool canShoot;

    private void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && canShoot)
        {
            canShoot = false;
            Instantiate(spikePrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
            StartCoroutine(ShootDelay());
        }
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(0.5f);
        canShoot = true;
    }
}
