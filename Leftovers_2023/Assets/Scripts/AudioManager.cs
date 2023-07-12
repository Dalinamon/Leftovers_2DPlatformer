using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Pelin volume slider scripti
public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private Slider volumeSlider;

    void Start()
    {
        // Etsii volume sliderin player prefseist� ja jos sit� ei l�ydy muttaa ��nenvoimakkuusen t�ysille
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    // Yhdist�� audiolistenerin volume slideriin
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    // Lataa playerprefseist� volume sliderin tiedot
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    // Tallentaa volume sliderin tiedot playerprefsiin
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}