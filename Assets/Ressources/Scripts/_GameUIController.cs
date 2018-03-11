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
    public UnityEngine.UI.Text stichwortAntwortText;
    public GameObject StichwortManager;



    void Start()
    {
        playerName.text = PlayerPrefs.GetString("playerName");
    }



    public void updateActionText(string a)
    {
        actionText.text = a;
    }

    public void updateStichwortAnzeigeText(string b)
    {

        stichwortAntwortText.text = b;
    }
  
}

