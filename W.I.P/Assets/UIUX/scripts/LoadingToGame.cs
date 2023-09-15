using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingToGame : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(StartTheGame());
    }
    public IEnumerator StartTheGame()
    {
        yield return new WaitForSeconds(7.5f);
        SceneManager.LoadScene("MainGame");
    }
}
