using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Animator fadeInAnimator;
    public void StartGameSwitch()
    {
        fadeInAnimator.SetTrigger("FadeIn");
        StartCoroutine(FadeIn());
    }
    public IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("LoadingScreen");
    }
}
