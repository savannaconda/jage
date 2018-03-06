using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Hier wird die Hauptmusik geregelt. 
 * Um eine zentrale Steuerung zu ermöglichen, braucht es ein _AudioSource Object, 
 * dem die entsprechende Musik zugeordnet ist .
 * Dann lässt sich die Auswahl auch zentral Toggeln. 
 * Die entsprechenden Musikverwendungfen sind auskommentiert
 * Sound und MusicController-Scripts sollen dem _Script Object zugeordnet werden
 */

public class MusicController : MonoBehaviour
{
    //Sammle MusikSurcen und UI Elemente
    public AudioSource music;
    public UnityEngine.UI.Toggle musicMuteToggle;
    public UnityEngine.UI.Slider musicSlider;
    public UnityEngine.UI.Text musicText;


    //Prüfe zu beginn, was Phase ist
    private void Awake()
    {
        if (PlayerPrefs.HasKey("isMusicMuted"))
        {
            if (PlayerPrefs.GetString("isMusicMuted") == "true")
            {
                if (musicMuteToggle != null)
                {
                    musicMuteToggle.isOn = false;
                }
            }
        }

        if (PlayerPrefs.HasKey("musicVolume"))
        {
            music.volume = PlayerPrefs.GetFloat("musicSoundVolume") / 100f;
        }

        if (musicSlider != null)

        {
            musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        }
        if (musicText != null)
        {
            musicText.text = PlayerPrefs.GetFloat("musicVolume").ToString();
        }
    }
    public void changeVolume(float f)
    {
        PlayerPrefs.SetFloat("musicVolume", f);
        music.volume = f / 100f;
        musicText.text = f.ToString();
    }
    public void toggleMute()
    {
        if (musicMuteToggle.isOn)
        {
            music.mute = false;

            PlayerPrefs.SetString("isMusicMuted", "false");

        }
        else
        {
            music.mute = true;
            PlayerPrefs.SetString("isMusicMuted", "true");
        }
    }

    void Update()
    {
        if (musicMuteToggle.isOn)
        {
            music.mute = false;

            PlayerPrefs.SetString("isMusicMuted", "false");

        }
        else
        {
            music.mute = true;
            PlayerPrefs.SetString("isMusicMuted", "true");
        }
    }

}
