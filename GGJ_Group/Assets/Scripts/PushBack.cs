using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBack : MonoBehaviour
{

    Rigidbody m_rigidBody;
    private float m_thrust = 5.0f;


    void Start()
    {

        m_rigidBody = GetComponent<Rigidbody>();

    }


    public void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.CompareTag("Tree"))
        {


            m_rigidBody.AddForce(-transform.forward * m_thrust, ForceMode.Impulse);

           
        }


    }



}
