using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHit : MonoBehaviour
{
    public DuracellTowerAI duracellTower;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == duracellTower.enemyTag)
        {
            Debug.Log("HIT");
        }
    }
}
