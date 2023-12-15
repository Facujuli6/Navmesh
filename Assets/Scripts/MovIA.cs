using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MovIA : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public GameObject goDestination1;
    public GameObject goDestination2;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.destination = goDestination1.transform.position;
        Enemy.destination = goDestination1.transform.position;
        
    }
}
