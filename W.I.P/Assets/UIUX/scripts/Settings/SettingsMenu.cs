using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    #region Links
    public AudioMixer audioMaster;

    public TMP_Dropdown resDropDown;
    public Resolution[] resolutions;
    public List<Resolution> filteredRes;

    public float currentRes;
    public int currentResIndex = 0;

    Resolution[] res;
    #endregion

    #region Start
    private void Start()
    {
        Res();
    }
    #endregion

    #region Sliders
    public void SFXSlider(float volumeS)
    {
        audioMaster.SetFloat("volumeSFX", volumeS);
    }

    public void MusicSlider(float volumeM)
    {
        audioMaster.SetFloat("volumeMusic", volumeM);
    }
    #endregion

    #region Fullscreen
    public void ScreenFull(bool isFull)
    {
        Screen.fullScreen = isFull;
    }
    #endregion

    #region Resolution
    public void Res()
    {
        res = Screen.resolutions;
        filteredRes = new List<Resolution>();

        resDropDown.ClearOptions();
        currentRes = Screen.currentResolution.refreshRate;


        for (int i = 0; i < res.Length; i++)
        {
            filteredRes.Add(res[i]);
        }

        List<string> options = new List<string>();
        
        for (int i = 0;i < filteredRes.Count;i++)
        {
            string resolutionOption = filteredRes[i].width + "x" + filteredRes[i].height;
            options.Add(resolutionOption);
            if (filteredRes[i].width == Screen.width && filteredRes[i].height == Screen.height)
            {
                currentRes = i;
            }
        }
        resDropDown.AddOptions(options);
        resDropDown.value = currentResIndex;
        resDropDown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = filteredRes[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, true);
    }
    #endregion
}
