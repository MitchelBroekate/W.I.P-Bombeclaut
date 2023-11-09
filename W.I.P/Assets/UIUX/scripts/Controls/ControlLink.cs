using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLink : MonoBehaviour
{
    public GameObject controlsUI;
    public void Controls()
    {
        if (controlsUI.activeInHierarchy == true)
        {
            controlsUI.SetActive(false);
        }
        else
        {
            controlsUI.SetActive(true);
        }

    }
}
