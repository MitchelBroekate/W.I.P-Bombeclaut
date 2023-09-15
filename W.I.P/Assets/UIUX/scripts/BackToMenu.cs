using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public GameObject activeScreen;
    public GameObject mainMenu;
    public TMP_Text normalText;

    public void BackToMenuSwitch()
    {
        activeScreen.SetActive(false);
        mainMenu.SetActive(true);
        Resize();
    }
    public void Resize()
    {
        normalText.fontSize = 90f;
    }
}
