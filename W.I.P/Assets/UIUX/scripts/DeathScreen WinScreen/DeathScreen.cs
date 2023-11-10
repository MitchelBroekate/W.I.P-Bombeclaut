using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void TryAgainButton()
    {
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1.0f;
    }
}
