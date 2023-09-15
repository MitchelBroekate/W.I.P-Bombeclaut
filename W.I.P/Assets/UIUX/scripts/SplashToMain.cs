using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMain : MonoBehaviour
{
    public AudioSource sFX;
    void Start()
    {
        StartCoroutine(SplashToMainSwitch());
        sFX.Play();
    }
    public IEnumerator SplashToMainSwitch()
    {
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene("MainMenu");
    }
}
