using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void ToFullScreen(bool toFullScreen)
    {
        Screen.fullScreen = toFullScreen;
    }


    public void ChangeVolume(float volume)
    {
        audioMixer.SetFloat("Volumen", volume);
    }

    public void ChangeQualityGame(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

}
