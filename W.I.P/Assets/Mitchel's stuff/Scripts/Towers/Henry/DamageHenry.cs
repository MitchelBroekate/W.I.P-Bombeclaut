using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHenry : MonoBehaviour
{
    EnemyAI enemyAI;

    private void OnTriggerEnter(Collider other)
    {
        enemyAI = other.GetComponent<EnemyAI>();

        if(other.gameObject.tag == "Enemy")
        {
            enemyAI.health = 0;
        }
    }
}
