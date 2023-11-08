using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    [SerializeField]
    private GameObject waypointsP;

    public void DevWaveSkip()
    {
        for (int i = 0; i < waypointsP.transform.childCount; i++)
        {
            Destroy(waypointsP.transform.GetChild(i).gameObject);
        }

        //WaveSystem waveSystem = gameObject.GetComponent<WaveSystem>();
        //waveSystem.waveStarter++;
    }

    public void DevAddMoney()
    {
        BaseScript baseScript = gameObject.GetComponent<BaseScript>();

        baseScript.moneyAmount += 10000;
    }


}
