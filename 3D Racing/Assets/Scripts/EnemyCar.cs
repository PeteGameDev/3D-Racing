using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCar : MonoBehaviour
{
    public GameObject playerCar;
    NavMeshAgent agent;

    void Start(){
        playerCar = GameObject.FindWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    void Update(){
        agent.destination = playerCar.transform.position;
    }
}
