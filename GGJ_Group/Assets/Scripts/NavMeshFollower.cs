using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshFollower : MonoBehaviour
{

    public GameObject player;

    private Transform waypoint;

    private NavMeshAgent agent;

   
    

   

    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        

    }

    public void ResetPath()
    {

        if(GameObject.FindWithTag("Tree"))
        {

            player = GameObject.FindWithTag("Tree");
            waypoint = player.transform;
            agent.destination = waypoint.position;

        }
        else if(!GameObject.FindWithTag("Tree"))
        {

            player = GameObject.FindWithTag("Player");
            waypoint = player.transform;
            agent.destination = waypoint.position;

        }

    }
    
    void Update()
    {

        ResetPath();


    }

  


    public void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.CompareTag("Tree"))
        {

            gameObject.SetActive(false);



        }

         if (collision.collider.CompareTag("Player"))
        {

            gameObject.SetActive(false);

        }

    }



}
