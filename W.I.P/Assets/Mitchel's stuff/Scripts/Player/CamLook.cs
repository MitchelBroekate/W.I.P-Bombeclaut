using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CamLook : MonoBehaviour
{
    #region Links
    private InputMaster controls;
    [SerializeField]
    private float mouseSens;

    private Vector2 camLook;

    private float xRotate = 0f;
    [SerializeField]
    private Transform playerBody;
    #endregion

    #region Awake and Update
    private void Awake()
    {
        playerBody = transform.parent;

        controls = new InputMaster();

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        CamMove();
    }
    #endregion

    #region Camera movement
    private void CamMove()
    {
        camLook = controls.Player.Cam.ReadValue<Vector2>();

        float mouseX = camLook.x * mouseSens * Time.deltaTime;
        float mouseY = camLook.y * mouseSens * Time.deltaTime;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotate, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
    }
    #endregion

    #region Mem Leaks
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
