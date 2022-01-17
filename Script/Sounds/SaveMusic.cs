using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveMusic : MonoBehaviour
{
    [SerializeField] private Slider volumeMusicSlider = null;

    void Start()
    {
        LoadValues();
    }
    public void SaveVolumeSlider()
    {
        float volumeMusicValue = volumeMusicSlider.value;
        PlayerPrefs.SetFloat("VolumeMusicValue", volumeMusicValue);
        LoadValues();
    }
    void LoadValues()
    {
        float volumeMusicValue = PlayerPrefs.GetFloat("VolumeMusicValue");
        float volumeSoundValue = PlayerPrefs.GetFloat("VolumeSoundValue");
        volumeMusicSlider.value = volumeMusicValue;
        AudioListener.volume = volumeMusicValue;
        AudioListener.volume = volumeSoundValue;
    }
}
