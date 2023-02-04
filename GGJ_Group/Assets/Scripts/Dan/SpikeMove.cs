using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));

        GetComponent<Rigidbody>().velocity = ray.direction * 80f;
        Destroy(gameObject, 2f);
    }
}
