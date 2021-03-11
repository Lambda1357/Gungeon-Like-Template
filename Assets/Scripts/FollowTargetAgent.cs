using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class FollowTargetAgent : MonoBehaviour
{
    public Transform target;

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(target)
            agent.destination = target.position;
    }
}
