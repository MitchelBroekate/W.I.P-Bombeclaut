using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class AddMap : MonoBehaviour
{
    public void Awake()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
    }
}
