using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    InputMaster controls;

    private void Awake()
    {
        controls = GetComponent<InputMaster>();
        controls.Player.PauseEsc.performed += x => PauseGame(); 
    }

    private void PauseGame()
    {

    }
}
