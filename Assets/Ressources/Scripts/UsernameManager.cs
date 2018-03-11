using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsernameManager : MonoBehaviour {

    public UnityEngine.UI.Text playerName;
    public UnityEngine.UI.Toggle soToggle;
    public UnityEngine.UI.Toggle musToggle;
    public UnityEngine.UI.Toggle einerToggle;
    public UnityEngine.UI.Toggle betrvgToggle;
    public UnityEngine.UI.Toggle bpersvgToggle;

    void Awake()
    {
        if (PlayerPrefs.HasKey("playerName"))
        {
            playerName.text = PlayerPrefs.GetString("playerName");
        }
        
        if (PlayerPrefs.GetString("soundON")=="true")
        {
            soToggle.isOn = true;
        }
        if (PlayerPrefs.GetString("musicON") == "true")
        {
            musToggle.isOn = true;
        }
        if (PlayerPrefs.GetString("einerON") == "true")
        {
            einerToggle.isOn = true;
        }
        if (PlayerPrefs.GetString("betrvgON") == "true")
        {
            betrvgToggle.isOn = true;

        }
        if (PlayerPrefs.GetString("bpersvgON") == "true")
        {
            bpersvgToggle.isOn = true;

        }




    }
            


    public void changeplayerName(string s)
    {
        s=playerName.text; //Ändern des Textes in wasauchimmer in s getippt wurde
        PlayerPrefs.SetString("playerName", s); //Überschreiben des in username gespeicherten Spielernamen

    }

    public void toggleSound()
    {
        if (soToggle.isOn)
        {   PlayerPrefs.SetString("soundON", "true");
        }
         
    }
    public void toggleEinerk()
    {
        if (einerToggle.isOn)
        {
            PlayerPrefs.SetString("einerON", "true");
        }
            
    }
    public void toggleBpers()
    {
        if (bpersvgToggle.isOn)
        {

            PlayerPrefs.SetString("bpersvgON", "true");
            PlayerPrefs.GetString("betrvgON", "false");
            betrvgToggle.isOn = false;
        }
    }
    public void toggleBetrVG()
    {
        if (betrvgToggle.isOn)
        {
            PlayerPrefs.SetString("betrvgON", "true");
            PlayerPrefs.SetString("bpersvgON", "false");
            bpersvgToggle.isOn = false;
        }
            
    }
    public void toggleMusic()
    {
        if (musToggle.isOn)
        {
            PlayerPrefs.SetString("musicON", "true");
        }
            
    }

}
