using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DevTools : MonoBehaviour
{
    [SerializeField]
    private GameObject waypointsP;

    public void DevWaveSkip(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SceneManager.LoadScene("Scene 2 Kitchen", LoadSceneMode.Single);
        }

    }

    public void DevAddMoney()
    {
        BaseScript baseScript = gameObject.GetComponent<BaseScript>();

        baseScript.moneyAmount += 10000;
    }


}
