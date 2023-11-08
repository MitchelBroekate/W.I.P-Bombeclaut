using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayAI : MonoBehaviour
{
    public Transform target;
    public Transform partToRotate;

    public string enemyTag = "Enemy";

    public ParticleSystem sprayShot;

    public float fireRadius;
    public float fireRate;
    private float fireCountdown = 0f;
    private void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    public void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= fireRadius)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }
    public void Update()
    {
        if (target == null)
            return;

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f , rotation.y, 0f);

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }
    private void Shoot()
    {
        sprayShot.Play();
        if(sprayShot.collision.sendCollisionMessages)
        {
            Debug.Log("Spray Hit");
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, fireRadius);
    }
}
