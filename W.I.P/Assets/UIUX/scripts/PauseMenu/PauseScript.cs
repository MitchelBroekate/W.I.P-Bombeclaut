using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class PauseScript : MonoBehaviour
{
    InputMaster controls;
    public GameObject volume;
    public GameObject hUD;
    public GameObject pauzeMenu;
    public bool pauzeIsOpen = false;
    public bool shopOpenBlock;
    public CamLook camLook;
    public Movement movement;
    public ShopOpen shopScript;
    public GameObject[] buttons;

    public Vector3 startFontSize;

    private void Awake()
    {
        controls = new InputMaster();
        controls.Player.PauseEsc.performed += x => PauseGame();
        startFontSize = transform.localScale;
    }

    private void PauseGame()
    {
        if(!shopOpenBlock)
        {
            if (!pauzeIsOpen)
            {
                Time.timeScale = 0.0f;
                pauzeMenu.SetActive(true);
                hUD.SetActive(false);
                volume.SetActive(true);
                pauzeIsOpen = true;
                camLook.canCamMove = false;
                movement.canMove = false;
                Cursor.lockState = CursorLockMode.None;
                shopScript.pauseMenuBlock = true;
            }
            else
            {
                Time.timeScale = 1.0f;
                pauzeMenu.SetActive(false);
                hUD.SetActive(true);
                volume.SetActive(false);
                pauzeIsOpen = false;
                camLook.canCamMove = true;
                movement.canMove = true;
                Cursor.lockState = CursorLockMode.Locked;
                shopScript.pauseMenuBlock = false;
                Resize();
            }
        }
    }
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    public void Resize()
    {
        foreach (GameObject button in buttons)
        {
            button.transform.localScale = startFontSize;
        }
    }
}
