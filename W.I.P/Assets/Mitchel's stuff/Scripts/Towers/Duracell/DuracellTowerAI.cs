using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DuracellTowerAI : MonoBehaviour
{
    RaycastHit hit;
    public Transform target;
    public float fireRadius;
    public string enemyTag = "Enemy";

    public Transform partToRotate;

    public ParticleSystem teslaShot;
    public float fireRate;
    private float fireCountdown = 0f;

    public AudioSource zapSound;

    public List<ParticleCollisionEvent> collisionEvents;
    private void Start()
    {
        var main = teslaShot.main;
        main.duration = fireRate;

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
        if(nearestEnemy != null && shortestDistance <= fireRadius)
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
        partToRotate.rotation = Quaternion.Euler(rotation.x += 55, rotation.y, 0f);

        if(fireCountdown <= 0f)
        {
            teslaShot.Play();
            zapSound.Play();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, fireRadius);
    }
}
