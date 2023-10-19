using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.SceneManagement;

public class ButtonPauseMenu : MonoBehaviour
{
    public GameObject hUD;
    public GameObject volume;
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    public GameObject areYouSureScreen;
    public ShopOpen shopScript;
    public PauseScript pauseScript;
    public CamLook camLook;
    public Movement movement;

    public GameObject[] buttons;

    public Vector3 startFontSize;

    public void Start()
    {
        startFontSize = transform.localScale;
    }
    public void ResumeButton()
    {
        Time.timeScale = 1.0f;
        volume.SetActive(false);
        pauseMenu.SetActive(false);
        hUD.SetActive(false);
        pauseScript.pauzeIsOpen = false;
        camLook.canCamMove = true;
        movement.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        shopScript.pauseMenuBlock = false;
        Resize();
    }
    public void SettingsButton()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
        pauseScript.shopOpenBlock = true;
        Resize();
    }
    public void BackToMainMenu()
    {
        pauseMenu.SetActive(false);
        areYouSureScreen.SetActive(true);
        pauseScript.shopOpenBlock = true;
        Resize();
    }
    public void AreYouSureYes()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void AreYouSureNo()
    {
        pauseMenu.SetActive(true);
        areYouSureScreen.SetActive(false);
        pauseScript.shopOpenBlock = false;
        Resize();
    }
    public void BackToMainPause()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
        pauseScript.shopOpenBlock = false;
        Resize();
    }
    public void Resize()
    {
        foreach (GameObject button in buttons)
        {
            button.transform.localScale = startFontSize;
        }
    }
}
