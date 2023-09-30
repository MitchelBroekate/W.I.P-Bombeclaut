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
    public Camera mainCam;
    Transform camStartPos;
    public Transform camEndPos;
    public float lerpTime;
    public bool shopIsOpen = false;
    bool canLerp;
    InputMaster controls;
    public CamLook camLook;
    public Movement movement;
    float time;
    public Transform pivot;
    Vector3 pivotX;
    public float camCooldown;
    public AudioSource sFX;
    public AudioClip shopOpenSFX;
    public AudioClip shopCloseSFX;
    #endregion

    #region Awake and update
    private void Awake()
    {
        controls = new InputMaster();
        movement = GetComponent<Movement>();
        controls.Player.ShopTab.performed += x => OpenShop();
    }
    private void Update()
    {
        time -= Time.deltaTime;
        if(time > 0)
        {
            if (canLerp)
            {
                mainCam.transform.position = Vector3.Lerp(mainCam.transform.position, camEndPos.position, lerpTime* Time.deltaTime);
                mainCam.transform.rotation = Quaternion.Lerp(mainCam.transform.rotation,camEndPos.rotation, lerpTime* Time.deltaTime);
            }
            else
            {
                mainCam.transform.position = Vector3.Lerp(mainCam.transform.position, pivot.position, lerpTime * Time.deltaTime);
                mainCam.transform.rotation = Quaternion.Slerp(mainCam.transform.rotation, pivot.rotation, lerpTime * Time.deltaTime);
            }
        }
    }
    #endregion

    #region Shop actions
    private void OpenShop()
    {
        if (!shopIsOpen)
        {
            camStartPos = mainCam.transform;
            sFX.clip = shopOpenSFX;
            sFX.Play();
            shop.SetActive(true);
            shopIsOpen = true;
            Cursor.lockState = CursorLockMode.None;
            camLook.canCamMove = false;
            movement.canMove = false;
            canLerp = true;
            controls.Player.ShopTab.Disable();
            StartCoroutine(CameraSnapUp());

            time = camCooldown;
        }
        else
        {
            sFX.clip = shopCloseSFX;
            sFX.Play();
            shop.SetActive(false);
            shopIsOpen = false;
            Cursor.lockState = CursorLockMode.Locked;
            movement.canMove = true;
            canLerp = false;
            controls.Player.ShopTab.Disable();
            StartCoroutine(CameraSnapDown());
            time = camCooldown;
        }
    }
    IEnumerator CameraSnapDown()
    {
        yield return new WaitForSeconds(camCooldown);
        camLook.canCamMove = true;
        controls.Player.ShopTab.Enable();
    }
    IEnumerator CameraSnapUp()
    {
        yield return new WaitForSeconds(camCooldown);
        controls.Player.ShopTab.Enable();
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
