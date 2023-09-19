using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private InputMaster controls;

    private float moveSpeed = 7f;

    private Vector3 velocity;

    private Vector2 move;

    private int sprint;

    private CharacterController controller;

    private void Awake()
    {
        controls = new InputMaster();
        controls = GetComponent<InputMaster>();

    }

    void Update()
    {
        PlayerMovement();

    }

    private void PlayerMovement()
    {
        move = controls.Player.Movement.ReadValue<Vector2>();

        Vector3 movement = (move.y * transform.forward) + (move.x * transform.right);

        controller.Move(movement * moveSpeed * Time.deltaTime);
    }

    private void SprintPressed() { }

    private void SprintReleased()
    {
        
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
