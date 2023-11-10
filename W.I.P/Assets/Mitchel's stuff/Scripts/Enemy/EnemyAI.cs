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

    private BaseScript baseScript; 

    private GameObject scriptLink;

    [SerializeField]
    private Transform[] checkpoints;

    public float moveSpeed = 1;

    [SerializeField]
    private int currentDest = 0;

    public int health;
    public int damage;
    public int addMoney;

    Quaternion toRot;
    #endregion

    #region Start and Update

    private void Start()
    {
        waypointsP = GameObject.Find("Checkpoints");
        scriptLink = GameObject.Find("Player");
        PrefabLink();
        
    }

    private void Update()
    {
        NextPoint();
        MoneyDeath();
    }
    #endregion

    //Change destination of enemy and rotate towards the current destination
    private void NextPoint()
    {


        if (Vector3.Distance(transform.position, checkpoints[currentDest].position) > 0.03f)
        {
            Vector3 destLook = new Vector3(checkpoints[currentDest].position.x, transform.position.y, checkpoints[currentDest].position.z) - transform.position;
            toRot = Quaternion.LookRotation(destLook, Vector3.up);

            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            transform.rotation = Quaternion.Lerp(transform.rotation, toRot, Time.deltaTime * 3f);

        }
        else
        {
            if (currentDest < checkpoints.Length - 1)
            {
                currentDest++;

            }
            else
            {

                baseScript = scriptLink.GetComponent<BaseScript>();

                  baseScript.health -= damage;
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
    
    private void MoneyDeath()
    {

            if (health < 1)
            {
                BaseScript baseScript = scriptLink.GetComponent<BaseScript>();

                baseScript.moneyAmount += addMoney;

                Destroy(gameObject);
            }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.transform.tag == "End"))
        {
            baseScript = scriptLink.GetComponent<BaseScript>();

            baseScript.health -= damage;
            Destroy(gameObject);
        }

    }

}