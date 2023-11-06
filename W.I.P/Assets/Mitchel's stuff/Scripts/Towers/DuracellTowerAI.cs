using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuracellTowerAI : MonoBehaviour
{
    public float fireRadius;
    public LayerMask enemyLayerMask;
    public GameObject emptyGameObject;
    

    public void Awake()
    {
        
    }
    public void UpdateTarget()
    {

    }
    public void ShootTower()
    {
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        if (Physics.CheckSphere(transform.position, fireRadius, enemyLayerMask))
        {
            
        }
    }
}
