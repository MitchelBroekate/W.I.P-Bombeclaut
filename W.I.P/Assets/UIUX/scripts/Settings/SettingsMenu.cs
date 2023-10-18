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
    public Slider musicSliderVar;
    public Slider sfxSliderVar;
    public Toggle fullScreenToggle;

    public TMP_Dropdown resDropDown;
    public Resolution[] resolutions;
    public List<Resolution> filteredRes;

    public float currentRes;
    public int currentResIndex = 0;
    bool fullCheck;

    Resolution[] res;
    #endregion

    #region Start
    private void Start()
    {
        Res();

        fullCheck = false;
        sfxSliderVar.value = PlayerPrefs.GetFloat("VolumeSfxPp", 1f);
        musicSliderVar.value = PlayerPrefs.GetFloat("VolumeMusicPp", 1f);
        if (PlayerPrefs.GetInt("FullScreenPp") == 1)
        {
            fullCheck = true;
        }
        else
        {
            fullCheck = false;
        }
        fullScreenToggle.isOn = fullCheck;
    }
    #endregion

    #region PlayerPrefSets
    public void SFXSlider(float volumeS)
    {
        audioMaster.SetFloat("volumeSFX", Mathf.Log10(volumeS) * 20);
        PlayerPrefs.SetFloat("VolumeSfxPp", volumeS);
    }

    public void MusicSlider(float volumeM)
    {
        audioMaster.SetFloat("volumeMusic", Mathf.Log10(volumeM) * 20);
        PlayerPrefs.SetFloat("VolumeMusicPp", volumeM);
    }
    #endregion

    #region Fullscreen
    public void ScreenFull(bool isMainFull)
    {
        Screen.fullScreen = isMainFull;
        Debug.Log(fullCheck);
        if (fullScreenToggle.isOn)
        {
            PlayerPrefs.SetInt("FullScreenPp", 1);
        }
        else
        {
            PlayerPrefs.SetInt("FullScreenPp", 0);
        }
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
            if (res[i].refreshRate == currentRes)
            {
                filteredRes.Add(res[i]);
            }
        }

        List<string> options = new List<string>();
        
        for (int i = 0;i < filteredRes.Count;i++)
        {
            string resolutionOption = filteredRes[i].width + "x" + filteredRes[i].height;
            options.Add(resolutionOption);
            if (filteredRes[i].width == Screen.width && filteredRes[i].height == Screen.height)
            {
                currentResIndex = i;
            }
            
        }
        resDropDown.AddOptions(options);
        resDropDown.value = currentResIndex;
        resDropDown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = filteredRes[resolutionIndex];
        Debug.Log(resolution.width + "+" + resolution.height);
        Screen.SetResolution(resolution.width, resolution.height, true);
        if(!fullScreenToggle.isOn)
        {
            ScreenFull(false);
        }
    }
    #endregion
}
