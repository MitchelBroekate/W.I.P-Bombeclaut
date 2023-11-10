using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHenry : MonoBehaviour
{
    EnemyAI enemyAI;
    bool doDamage = true;

    private void OnTriggerEnter(Collider other)
    {
        enemyAI = other.GetComponent<EnemyAI>();

        if(other.gameObject.tag == "Enemy")
        {
            StartCoroutine(Wait(5));
        }


    }

    IEnumerator Wait(int waitTime)
    {
        if (doDamage)
        {
            enemyAI.health = 0;
        }
        doDamage = false;
        yield return new WaitForSeconds(waitTime);
        doDamage = true;

        yield return null;
    }
}
