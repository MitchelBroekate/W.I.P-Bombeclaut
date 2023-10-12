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

    [SerializeField]
    int waveStarter = 0;

    public bool tutWave = false, wave1 = false, wave2 = false;
    #endregion


    //Checks to start the Waves
    private void WaveChecks()
    {
        switch (waveStarter)
        {
            case 1:
                tutWave = true;
                StartCoroutine(SpawnWaves());
                tutWave = false;
                break;

            case 2:
                wave1 = true;
                StartCoroutine(SpawnWaves());
                wave1 = false;
                break;

            case 3:
                wave2 = true;
                StartCoroutine(SpawnWaves());
                wave2 = false;
                break;
        }
    }




    //IEnumerator for enemy spawning with intervals
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
            yield return new WaitForSeconds(2);

            for (int i = 0;i < 3 ; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);
            yield return new WaitForSeconds(2);

            for (int i = 0;i < 3 ; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);
            yield return new WaitForSeconds(2);

            for (int i = 0; i < 3; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);
            yield return new WaitForSeconds(2);

            for (int i = 0; i < 3; i++)
            {
                antEnemy = Instantiate(pAnt, spawn.transform);

                yield return new WaitForSeconds(2);
            }

            spiderEnemy = Instantiate(pSpider, spawn.transform);
            yield return new WaitForSeconds(2);
        }

        if (wave2)
        {


        }
    }

}