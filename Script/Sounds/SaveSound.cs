using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSound : MonoBehaviour
{
    [SerializeField] private Slider volumeSoundSlider = null;

    void Start()
    {
        LoadValues();
    }
    public void SaveVolumeSlider()
    {
        float volumeSoundValue = volumeSoundSlider.value;
        PlayerPrefs.SetFloat("VolumeSoundValue", volumeSoundValue);
        LoadValues();
    }
    void LoadValues()
    {
        float volumeSoundValue = PlayerPrefs.GetFloat("VolumeSoundValue");
        float volumeMusicValue = PlayerPrefs.GetFloat("VolumeMusicValue");
        volumeSoundSlider.value = volumeSoundValue;
        AudioListener.volume = volumeSoundValue;
        AudioListener.volume = volumeMusicValue;
    }
}
