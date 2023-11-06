using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class EnemyAI : MonoBehaviour
{
    #region Links
    private GameObject waypointsP;

    [SerializeField]
    private Transform[] checkpoints;

    public float moveSpeed = 1;

    [SerializeField]
    private int currentDest = 0;

    float timeCount = 0;

    Quaternion toRot;
    #endregion

    #region Start and Update

    private void Start()
    {
        waypointsP = GameObject.Find("Checkpoints");
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


        if (Vector3.Distance(transform.position, checkpoints[currentDest].position) > 0.01f)
        {
            Vector3 destLook = new Vector3(checkpoints[currentDest].position.x, transform.position.y, checkpoints[currentDest].position.z) - transform.position;
            toRot = Quaternion.LookRotation(destLook, Vector3.up);

            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            transform.rotation = Quaternion.Lerp(transform.rotation, toRot, timeCount);
            timeCount = timeCount + Time.deltaTime * 0.5f;

        }
        else
        {
            if (currentDest < checkpoints.Length - 1)
            {
                currentDest++;

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