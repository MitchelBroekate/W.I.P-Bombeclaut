using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainToSettings : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
    public TMP_Text normalText;

    public void SettingsSwitch()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
        Resize();
    }
    public void Resize()
    {
        normalText.fontSize = 24f;
    }
}
