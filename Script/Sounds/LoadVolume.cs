using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadVolume : MonoBehaviour
{
    [SerializeField] private Slider volumeMusicSlider = null;
    [SerializeField] private Slider volumeSoundSlider = null;

    void Start()
    {
        LoadValues();
    }

    void LoadValues()
    {
        float volumeMusicValue = PlayerPrefs.GetFloat("VolumeMusicValue");
        float volumeSoundValue = PlayerPrefs.GetFloat("VolumeSoundValue");
        volumeMusicSlider.value = volumeMusicValue;
        volumeSoundSlider.value = volumeSoundValue;
        AudioListener.volume = volumeMusicValue;
        AudioListener.volume = volumeSoundValue;
    }
}
