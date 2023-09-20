using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuSwitches : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
    public GameObject credits;

    public Animator fadeInAnimator;
    public GameObject[] buttons;

    public Vector3 startFontSize;

    public void Start()
    {
        startFontSize = transform.localScale;
    }
    public void StartGameSwitch()
    {
        fadeInAnimator.SetTrigger("FadeIn");
        StartCoroutine(FadeIn());
    }
    public IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("LoadingScreen");
    }
    public void SettingsSwitch()
    {
        Resize();
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }
    public void CreditsSwitch()
    {
        Resize();
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }
    public void BackToMenuSwitchSettings()
    {
        Resize();
        settings.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void BackToMenuSwitchCredits()
    {
        Resize();
        credits.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void Resize()
    {
        foreach(GameObject button in buttons)
        {
            button.transform.localScale = startFontSize;
        }
    }
}
