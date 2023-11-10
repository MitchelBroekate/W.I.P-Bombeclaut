using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void NextLevelButton()
    {
        SceneManager.LoadScene("Scene 2 Kitchen");
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void WinToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
