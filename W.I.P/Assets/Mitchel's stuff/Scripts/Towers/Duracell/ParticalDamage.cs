using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalDamage : MonoBehaviour
{
    void OnParticleCollision(GameObject other)
    {
        if(other.GetComponent<EnemyAI>() != null)
        {
            EnemyAI enemyAI = other.GetComponent<EnemyAI>();
            enemyAI.health -= 25;
            Debug.Log("HIT");
        }
    }
}
