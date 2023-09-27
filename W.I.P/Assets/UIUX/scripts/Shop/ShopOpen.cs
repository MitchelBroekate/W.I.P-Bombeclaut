using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShopOpen : MonoBehaviour
{
    #region Links
    public GameObject shop;
    public bool shopIsOpen = false;
    InputMaster controls;
    CamLook camLook;
    Movement movement;
    #endregion

    #region Awake
    private void Awake()
    {
        controls = new InputMaster();
        camLook = transform.GetChild(0).GetComponent<CamLook>();
        movement = GetComponent<Movement>();
        controls.Player.ShopTab.performed += x => OpenShop();
    }
    #endregion

    #region Shop actions
    private void OpenShop()
    {
        if (!shopIsOpen)
        {
            shop.SetActive(true);
            shopIsOpen = true;
            Cursor.lockState = CursorLockMode.None;
            camLook.canCamMove = false;
            movement.canMove = false;
        }
        else
        {
            shop.SetActive(false);
            shopIsOpen = false;
            Cursor.lockState = CursorLockMode.Locked;
            camLook.canCamMove = true;
            movement.canMove = true;
        }
    }
    #endregion

    #region Enable/Disable Mem leaks
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    #endregion
}
