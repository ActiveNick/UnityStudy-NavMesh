using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ArrowNPCMovement : MonoBehaviour {

    public GameObject targetGO;
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        HeadForDestintation();
    }
    private void HeadForDestintation()
    {
        Vector3 destinaton = targetGO.transform.position;
        navMeshAgent.SetDestination(destinaton);
    }
}
