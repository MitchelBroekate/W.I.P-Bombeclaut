using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartBGAnimation : MonoBehaviour
{
    public PlayableDirector bGAnimation;
    private void Start()
    {
        bGAnimation.playOnAwake = true;
    }
}
