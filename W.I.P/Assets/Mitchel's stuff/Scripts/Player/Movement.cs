using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    #region Link
    private InputMaster controls;
    private Vector2 move;
    public bool canMove = true;

    [SerializeField]
    private float moveSpeed;

    private float walkSpeed;

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
        walkSpeed = moveSpeed;
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
        if (canMove)
        {
            move = controls.Player.Movement.ReadValue<Vector2>();

            Vector3 movement = (move.y * transform.forward) + (move.x * transform.right);

            controller.Move(movement * moveSpeed * Time.deltaTime);
        }
        else
        {
        
        }
    }
    #endregion

    #region SprintCheck
    private void SprintCheck() 
    {
        if (isSprinting)
        {
            moveSpeed = 2;
        }
        else
        {
            moveSpeed = walkSpeed;
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