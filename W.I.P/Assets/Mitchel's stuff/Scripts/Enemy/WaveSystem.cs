using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem;

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
    private int waveStarter = 0;

    private bool tutWave = false, wave1 = false, wave2 = false;
    #endregion

    private void Update()
    {
        WaveChecks();
    }

    //Checks to start the Waves
    private void WaveChecks()
    {
        switch (waveStarter)
        {
            case 1:
                Debug.Log("startwave");
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

    public void ReadyWave(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (spawn.transform.childCount < 1)
            {
                waveStarter++;
            }
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