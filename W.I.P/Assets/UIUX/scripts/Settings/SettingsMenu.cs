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
    float fullCheck;

    Resolution[] res;
    #endregion

    #region Start and Update
    private void Start()
    {
        Res();

        sfxSliderVar.value = PlayerPrefs.GetFloat("VolumeSfxPp", 1f);
        musicSliderVar.value = PlayerPrefs.GetFloat("VolumeMusicPp", 1f);
        fullCheck = PlayerPrefs.GetFloat("FullScreenPp", 1);
    }
    private void Update()
    {
        if (fullCheck == 0)
        {
            fullScreenToggle.isOn = false;
        }
        else
        {
            fullScreenToggle.isOn = true;
        }
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
    public void FullScreenpp(float fullscreen)
    {
        PlayerPrefs.SetFloat("FullScreenPp", fullscreen);
    }
    #endregion

    #region Fullscreen
    public void ScreenFull(bool isMainFull)
    {
        Screen.fullScreen = isMainFull;
        FullScreenpp(fullCheck);
        Debug.Log(fullCheck);
        if (fullCheck == 1)
        {
            fullCheck = 0;
        }
        else
        {
            fullCheck = 1;
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
    }
    #endregion
}
