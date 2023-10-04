using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class ButtonPauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
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
        pauseMenu.SetActive(false);
        pauseScript.pauzeIsOpen = false;
        camLook.canCamMove = true;
        movement.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        shopScript.pauseMenuBlock = false;
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
