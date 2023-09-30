using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    InputMaster controls;
    public GameObject pauzeMenu;
    public bool pauzeIsOpen = false;
    public CamLook camLook;
    public Movement movement;

    private void Awake()
    {
        controls = new InputMaster();
        controls.Player.PauseEsc.performed += x => PauseGame(); 
    }

    private void PauseGame()
    {
        if (!pauzeIsOpen)
        {
            pauzeMenu.SetActive(true);
            pauzeIsOpen = true;
            camLook.canCamMove = false;
            movement.canMove = false;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            pauzeMenu.SetActive(false);
            pauzeIsOpen = false;
            camLook.canCamMove = true;
            movement.canMove = true;
            Cursor.lockState = CursorLockMode.Locked;
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
}
