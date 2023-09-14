using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainToCredits : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;
    public TMP_Text normalText;

    public void CreditsSwitch()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
        Resize();
    }
    public void Resize()
    {
        normalText.fontSize = 24f;
    }
}
