using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZContr : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform dest;
    void Start()
    {
        
    }

    void Update()
    {
        agent.SetDestination(dest.position);
    }

    void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject.tag == "sword")
        {
            Destroy(gameObject);
        }
    }
}
