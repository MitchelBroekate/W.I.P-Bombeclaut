using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public GameObject activeScreen;
    public GameObject mainMenu;

    public Vector3 startFontSize;

    public void Start()
    {
        startFontSize = transform.localScale;
    }
    public void BackToMenuSwitch()
    {
        activeScreen.SetActive(false);
        mainMenu.SetActive(true);
        Resize();
    }
    public void Resize()
    {
        transform.localScale = startFontSize;
    }
}
