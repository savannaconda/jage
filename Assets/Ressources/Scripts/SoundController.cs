using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Hier wird jeder Sound geregelt. 
 * Um eine zentrale Steuerung zu ermöglichen, braucht es ein _AudioSource Object, 
 * dem die entsprechenden Sounds zugeordnet sind.
 * Dann lässt sich die Auswahl auch zentral Toggeln. 
 * Die entsprechenden Soundverwendungfen sind auskommenbtiert
 * Sound und MusicController-Scripts sollen dem _Script Object zugeordnet werden
 */


public class SoundController : MonoBehaviour
{
    //Sammlung aller Sounds
  
    public AudioSource click;
    public AudioSource phone;
    public AudioSource bla;
    public AudioSource lettersound;

    //Sammlung der Regler
    public UnityEngine.UI.Toggle soundMuteToggle;
    public UnityEngine.UI.Slider soundSlider;
    public UnityEngine.UI.Text soundText;


    //Überprüft, ob Sound aktiviert, oder deaktiviert wurde
    private void Awake()
    {
        if (PlayerPrefs.HasKey("isSoundMuted"))
        {
            if (PlayerPrefs.GetString("isSoundMuted") == "true")
            {
                if (soundMuteToggle != null)
                {
                    soundMuteToggle.isOn = false;
                }
            }
        }

        //Überprüft, ob Lautstärke geregelt wurde und passt diese entsprechend an
        if (PlayerPrefs.HasKey("soundVolume"))
        {
           
            click.volume = PlayerPrefs.GetFloat("lvlupVolume") / 100f;
            phone.volume = PlayerPrefs.GetFloat("lvlupVolume") / 100f;
            bla.volume = PlayerPrefs.GetFloat("lvlupVolume") / 100f;
            lettersound.volume = PlayerPrefs.GetFloat("lvlupVolume") / 100f;
        }

        if (soundSlider != null)

        {
            soundSlider.value = PlayerPrefs.GetFloat("soundVolume");
        }
        if (soundText != null)
        {
            soundText.text = PlayerPrefs.GetFloat("soundVolume").ToString();
        }
    }
    public void changeVolume(float f)
    {
        PlayerPrefs.SetFloat("soundVolume", f);
        click.volume = f / 100f;
        phone.volume = f / 100f;
        bla.volume = f / 100f;
        lettersound.volume = f / 100f;
        soundText.text = f.ToString();
    }

    //Hier wird Stummschaltung geprüft oder damit Umgegangen, da es sich um einschriebe in die PlayerPrefs handelt, gilt dies dann für alle Szenen
    public void toggleMute()
    {
        if (soundMuteToggle.isOn)
        {
            
            click.mute = false;
            phone.mute = false;
            bla.mute = false;
            lettersound.mute = false;

            PlayerPrefs.SetString("isSoundMuted", "false");

        }

        else
        {
            phone.mute = true;
            click.mute = true;
            bla.mute = true;
            lettersound.mute = true;
            PlayerPrefs.SetString("isSoundMuted", "true");
        }
    }

    private void Update()
    {

        if (soundMuteToggle.isOn)
        {
            phone.mute = false;
            click.mute = false;
            bla.mute = false;
            lettersound.mute = false;
            PlayerPrefs.SetString("isSoundMuted", "false");

        }
        else
        {
            phone.mute = true;
            click.mute = true;
            bla.mute = true;
            lettersound.mute = true;
            PlayerPrefs.SetString("isSoundMuted", "true");
        }
    }

}
