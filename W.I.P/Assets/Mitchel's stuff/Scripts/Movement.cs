using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    #region Variables
    private InputMaster controls;
    private Vector2 move;

    [SerializeField]
    private float moveSpeed = 7;

    [SerializeField]
    private CharacterController controller;

    [SerializeField]
    private bool isSprinting;
    #endregion

    #region Awake and Update
    private void Awake()
    {
        controls = new InputMaster();
        controls.Player.SprintStart.performed += x => isSprinting = true;
        controls.Player.SprintStart.canceled += x => isSprinting = false;

    }

    void Update()
    {
        PlayerMovement();
        SprintCheck();
    }
    #endregion

    #region Movement void
    private void PlayerMovement()
    {
        move = controls.Player.Movement.ReadValue<Vector2>();

        Vector3 movement = (move.y * transform.forward) + (move.x * transform.right);

        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
    #endregion

    #region SprintCheck
    private void SprintCheck() 
    {
        if (isSprinting)
        {
            moveSpeed = 10;
        }
        else
        {
            moveSpeed = 7;
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