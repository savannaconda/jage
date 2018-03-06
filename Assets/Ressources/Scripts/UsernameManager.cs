using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsernameManager : MonoBehaviour {

    public UnityEngine.UI.Text playerName;

    void Awake()
    {
        if (PlayerPrefs.HasKey("username"))
        {
            playerName.text = PlayerPrefs.GetString("username");
        }
    }

    public void changeplayerName(string s)
    {
        playerName.text = s; //Ändern des Textes in wasauchimmer in s getippt wurde
        PlayerPrefs.SetString("username", s); //Überschreiben des in username gespeicherten Spielernamen
    }
}
