using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class EnemyAI : MonoBehaviour
{
    #region Links
    private NavMeshAgent agent;

    private GameObject waypointsP;

    LookAtConstraint lookAtConstraint;

    [SerializeField]
    private Transform[] checkpoints;
    private int curCheckPoint;
    public float checkPointReachedDistance = 0.5f;
    public float moveSpeed = 1;

    [SerializeField]
    private int currentDest = 0;


    float timeCount = 0;

    Ray ray;
    RaycastHit hit;

    Quaternion toRot;
    #endregion

    #region Awake and Update

    private void Start()
    {
        waypointsP = GameObject.Find("Checkpoints");
        agent = GetComponent<NavMeshAgent>();
        PrefabLink();
        
    }

    private void Update()
    {
        NextPoint();
    }
    #endregion

    //Change destination of enemy and rotate towards the current destination
    private void NextPoint()
    {


        if (Vector3.Distance(transform.position, checkpoints[currentDest].position) > 0.1f)
        {
            Vector3 destLook = new Vector3(checkpoints[currentDest].position.x, transform.position.y, checkpoints[currentDest].position.z) - transform.position;
            toRot = Quaternion.LookRotation(destLook, Vector3.up);

            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);



        }
        else
        {
            if (currentDest < checkpoints.Length - 1)
            {
                currentDest++;

                transform.rotation = Quaternion.Lerp(transform.rotation, toRot, timeCount);
                timeCount = timeCount + Time.deltaTime * 0.5f;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    //Linking prefabs index array
    private void PrefabLink()
    {
        for (int i = 0; i < waypointsP.transform.childCount; i++)
        {
            checkpoints[i] = waypointsP.transform.GetChild(i).transform;
        }
    }

}