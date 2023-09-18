using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainToCredits : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;

    public Vector3 startFontSize;

    public void Start()
    {
        startFontSize = transform.localScale;
    }
    public void CreditsSwitch()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
        Resize();
    }
    public void Resize()
    {
        transform.localScale = startFontSize;
    }
}
