using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    #region Links
    [SerializeField]
    private Transform spawn;

    [SerializeField]
    private GameObject pAnt, pSpider;

    [SerializeField]
    private GameObject antEnemy, spiderEnemy;

    public bool tutWave, wave1, wave2;

    private float waitTime = 1f;

    private Vector3 spawnpoint;
    #endregion

    #region Awake and update
    private void Awake()
    {
        tutWave = true;
    }

    private void Update()
    {
        WaveChecks();
    }
    #endregion

    #region Checking waves
    private void WaveChecks()
    {

        if (tutWave)
        {
            StartCoroutine(SpawnWaves(waitTime));
        }

        if (wave1)
        {
            StartCoroutine(SpawnWaves(waitTime));
        }

        if (wave2)
        {
            StartCoroutine(SpawnWaves(waitTime));
        }
    }
    #endregion

    #region Wave spawn interval IEn
    public IEnumerator SpawnWaves(float interval)
    {
        if (tutWave)
        {
            for (int i = 0; i < 10; i++)
            {
                antEnemy  = Instantiate(pAnt);
                antEnemy.transform.position = spawnpoint;

                yield return new WaitForSeconds(interval);
            }
        }

        if (wave1)
        {

            yield return new WaitForSeconds(interval);
        }

        if (wave2)
        {

            yield return new WaitForSeconds(interval);
        }

    }
    #endregion
}