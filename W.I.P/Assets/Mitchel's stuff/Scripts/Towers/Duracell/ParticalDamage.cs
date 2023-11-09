using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalDamage : MonoBehaviour
{
    public int damage;
    void OnParticleCollision(GameObject other)
    {
        if(other.GetComponent<EnemyAI>() != null)
        {
            EnemyAI enemyAI = other.GetComponent<EnemyAI>();
            enemyAI.health -= damage;
            Debug.Log("HIT");
        }
    }
}
