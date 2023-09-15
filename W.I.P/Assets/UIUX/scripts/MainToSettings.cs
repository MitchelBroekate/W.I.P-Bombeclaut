using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainToSettings : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;

    public Vector3 startFontSize;

    public void Start()
    {
        startFontSize = transform.localScale;
    }

    public void SettingsSwitch()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
        Resize();
    }
    public void Resize()
    {
        transform.localScale = startFontSize;
    }
}
