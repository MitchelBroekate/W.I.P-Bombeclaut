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
    private GameObject win;

    public int waveStarter = 0;

    private bool tutWave = false, wave1 = false, wave2 = false, wave3 = false, wave4 = false, wave5 = false;
    private bool case1 = true, case2 = true, case3 = true, case4 = true, case5 = true, case6 = false;
    #endregion

    //updates the waveChecks
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
                if (case1)
                {
                    tutWave = true;
                    StartCoroutine(SpawnWaves());
                    tutWave = false;
                    case1 = false;
                }

                break;

            case 2:
                if (case2)
                {
                    wave1 = true;
                    StartCoroutine(SpawnWaves());
                    wave1 = false;
                    case2 = false;
                }

                break;

            case 3:
                if (case3)
                {
                    wave2 = true;
                    StartCoroutine(SpawnWaves());
                    wave2 = false;
                    case3 = false;
                }

                break;

            case 4:
                if (case4)
                {
                    wave3 = true;
                    StartCoroutine(SpawnWaves());
                    wave3 = false;
                    case4 = false;
                }

                break;

            case 5:
                if (case5)
                {
                    wave4 = true;
                    StartCoroutine(SpawnWaves());
                    wave4 = false;
                    case5 = false;
                }

                break;

            case 6:
                if (case6)
                {
                    wave5 = true;
                    StartCoroutine(SpawnWaves());
                    wave5 = false;
                    case6 = false;
                }
                break;

            case 7:
                win.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                waveStarter = 0;
                break;
        }
    }

    //starts next wave when enemies are all gone
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

                antEnemy.tag = "Enemy";

                yield return new WaitForSeconds(3.5f);
            }
        }

        if (wave1)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int i = 0; i < 3; i++)
                {
                    antEnemy = Instantiate(pAnt, spawn.transform);

                    antEnemy.tag = "Enemy";

                    yield return new WaitForSeconds(2);
                }

                spiderEnemy = Instantiate(pSpider, spawn.transform);

                spiderEnemy.tag = "Enemy";

                yield return new WaitForSeconds(2);
            }
        }

        if (wave2)
        {
            for (int a = 0; a < 4; a++)
            {
                for (int i = 0; i < 3; i++)
                {
                    antEnemy = Instantiate(pAnt, spawn.transform);

                    antEnemy.tag = "Enemy";

                    yield return new WaitForSeconds(1.5f);
                }

                for (int i = 0; i < 4; i++)
                {
                    spiderEnemy = Instantiate(pSpider, spawn.transform);

                    spiderEnemy.tag = "Enemy";

                    yield return new WaitForSeconds(2);
                }
            }

            if (wave3)
            {
                for (int a = 0; a < 4; a++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        antEnemy = Instantiate(pAnt, spawn.transform);

                        antEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1);
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        spiderEnemy = Instantiate(pSpider, spawn.transform);

                        spiderEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1.5f);
                    }
                }
            }

            if (wave4)
            {
                for (int a = 0; a < 5; a++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        spiderEnemy = Instantiate(pSpider, spawn.transform);

                        spiderEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1.5f);
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        antEnemy = Instantiate(pAnt, spawn.transform);

                        antEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1);
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        spiderEnemy = Instantiate(pSpider, spawn.transform);

                        spiderEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1);
                    }
                }
            }

            if (wave5)
            {
                for (int a = 0; a < 6; a++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        spiderEnemy = Instantiate(pSpider, spawn.transform);

                        spiderEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1.5f);
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        antEnemy = Instantiate(pAnt, spawn.transform);

                        antEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1);
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        spiderEnemy = Instantiate(pSpider, spawn.transform);

                        spiderEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1);
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        antEnemy = Instantiate(pAnt, spawn.transform);

                        antEnemy.tag = "Enemy";

                        yield return new WaitForSeconds(1.5f);
                    }

                }
            }

        }
    }
}