using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// UI Controller regelt einige UI Funktionen unter anderem den Nick
//Am besten an die UI heften

public class _GameUIController : MonoBehaviour
{

    public UnityEngine.UI.Text playerName; //hier soll später der zuvor eingegebene Spielername erscheinen
    public UnityEngine.UI.Text actionText;



    void Start()
    {
        if (PlayerPrefs.HasKey("username"))
        {
            playerName.text = PlayerPrefs.GetString("username");
        }
        //Ziehe den Spielernamen aus den Prefs
        else
        {
            playerName.text = "Kreativname";
        }
    }

    public void updateActionText(string a)
    {
        actionText.text = a;
    }
}

