using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    #region Links
    private NavMeshAgent agent;

    private GameObject waypointsP;
    private int amountOfPoints;

    [SerializeField]
    private Transform[] checkpoints;

    [SerializeField]
    private int currentDest = 0;
    #endregion

    #region Awake and Update
    private void Awake()
    {
        waypointsP = GameObject.Find("Checkpoints");
        amountOfPoints = waypointsP.transform.childCount;

        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
    }

    private void Update()
    {
        PrefabLink();
        NextPoint();
    }
    #endregion

    #region Destination changing
    private void NextPoint()
    {
        if (currentDest != checkpoints.Length)
        {
            agent.destination = checkpoints[currentDest].position;

            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {

                currentDest += 1;
            }
        }
    }
    #endregion

    private void PrefabLink()
    {
        for (int i = 0; i < waypointsP.transform.childCount; i++)
        {
            checkpoints[i] = waypointsP.transform.GetChild(i).transform;
        }
    }

}