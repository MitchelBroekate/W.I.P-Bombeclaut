using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    #region Links
    [SerializeField]
    private GameObject spawn;

    [SerializeField]
    private GameObject pAnt, pSpider;

    [SerializeField]
    private GameObject antEnemy, spiderEnemy;

    public bool tutWave = false, wave1 = false, wave2 = false;
    #endregion

    #region Awake and update
    private void Awake()
    {
        wave1 = true;
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
            StartCoroutine(SpawnWaves());

            tutWave = false;
        }

        if (wave1)
        {
            StartCoroutine(SpawnWaves());

            wave1 = false;
        }

        if (wave2)
        {
            StartCoroutine(SpawnWaves());

            wave2 = false;
        }
    }
    #endregion

    #region Wave spawn interval IEn
    public IEnumerator SpawnWaves()
    {
        if (tutWave)
        {
            for (int i = 0; i < 10; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(1);
            }
        }

        if (wave1)
        {
            for(int i = 0;i < 3; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);

            for(int i = 0;i < 3 ; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);

            for (int i = 0;i < 3 ; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);

            for (int i = 0; i < 3; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);

            for (int i = 0; i < 3; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);

        }

        if (wave2)
        {


        }
    }
    #endregion
}