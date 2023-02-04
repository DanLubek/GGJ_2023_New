using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public GameObject Spawner;

    public float time;

    void Start()
    {

        StartCoroutine(turnOn(Spawner));

    }

    IEnumerator turnOn(GameObject spawnerName)
    {


        yield return new WaitForSeconds(time);
        spawnerName.SetActive(true);


    }

}
