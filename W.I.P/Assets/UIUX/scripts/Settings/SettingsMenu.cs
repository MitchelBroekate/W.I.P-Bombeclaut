using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMaster;

    public TMP_Dropdown resDropDown;

    Resolution[] res;

    private void Start()
    {
        res = Screen.resolutions;

        resDropDown.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i < res.Length; i++) 
        {
            string option = res[i].width + "x" + res[i].height;

            options.Add(option);
        }

        resDropDown.AddOptions(options);
    }
    public void SFXSlider(float volumeS)
    {
        audioMaster.SetFloat("volumeSFX", volumeS);
    }

    public void MusicSlider(float volumeM)
    {
        audioMaster.SetFloat("volumeMusic", volumeM);
    }

    public void ScreenFull(bool isFull)
    {
        Screen.fullScreen = isFull;
    }
}
