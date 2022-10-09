using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;
    [SerializeField] private Transform _player;

    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    int m_CurrentWaypointIndex;

    void Start ()
    {

        navMeshAgent.SetDestination (waypoints[0].position);
    }

    void Update ()
    {
        RaycastHit hit;

        var startPos = transform.position;
        startPos.y += 0.5f;
        var dir = _player.position - startPos;
        dir.y += 0.5f;

        var rayCast = Physics.Raycast(startPos, dir, out hit, Mathf.Infinity,
        _mask);

        Color color = new Color(0f, 0f, 0f, 0f);
        color = Color.red;
        if (rayCast)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                color = Color.green;
                navMeshAgent.SetDestination(_player.position);
            }
            
            
        }
        //Debug.DrawRay(transform.position, Vector3.forward, Color.red);

        Debug.DrawRay(startPos, dir, color);

        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
        }


    }

    

    

}
