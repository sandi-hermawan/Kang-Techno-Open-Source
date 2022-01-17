using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySounds : MonoBehaviour
{
    public AudioSource sound;
    public Slider volume_sound;

    public void playSound()
    {
        sound.PlayOneShot(sound.clip);
        sound.volume = volume_sound.value;
    }
}
