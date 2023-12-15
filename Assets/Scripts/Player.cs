using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Player : MonoBehaviour
{ 
    public NavMeshAgent agent;
    public GameObject goDestination;
    void Start()
    {
        agent.destination = goDestination.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goDestination.transform.position;
    }
}
