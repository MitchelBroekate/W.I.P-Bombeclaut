using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    [SerializeField]
    private GameObject waypointsP;

    private WaveSystem waveSystem;

    private void Start()
    {
        //waveSystem = gameObject.GetComponent<WaveSystem>();
    }
    public void DevWaveSkip()
    {
        for (int i = 0; i < waypointsP.transform.childCount; i++)
        {
            Destroy(waypointsP.transform.GetChild(i).gameObject);
        }

        //waveSystem.waveStarter++;
    }


}
