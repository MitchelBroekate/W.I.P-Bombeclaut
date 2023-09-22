using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    #region Links
    private NavMeshAgent agent;

    [SerializeField]
    private Transform[] checkpoints;

    [SerializeField]
    private int currentDest = 0;
    #endregion

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
    }

    private void Update()
    {
        NextPoint();
    }

    private void NextPoint()
    {
        agent.destination = checkpoints[currentDest].position;

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
                currentDest += 1;
        }

    }
}