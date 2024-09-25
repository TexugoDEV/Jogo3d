using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentIA : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> wayPoint;
    NavMeshAgent navMeshAgent;
    public int currentWaypointIndex = 0;
    private Animator anim;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walking();
       

    }
    private void Walking()
    {
        if (wayPoint.Count == 0)
        {
            return;
        }
        float distanceToWaypoint = Vector3.Distance(wayPoint[currentWaypointIndex
            ].position, transform.position);

        if (distanceToWaypoint <- 2)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % wayPoint.Count;
        }

        navMeshAgent.SetDestination(wayPoint[currentWaypointIndex].position);

    }
}
