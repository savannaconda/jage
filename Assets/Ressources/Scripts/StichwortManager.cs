using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StichwortManager : MonoBehaviour {
    public _GameUIController uiController;
    public UnityEngine.UI.Text stichwortText;
    public UnityEngine.UI.Text stichwortInputText;
    public string b;

	// Use this for initialization
	void Start () 
    {
		
	}

    public void setStichwort()
    {
        
        b = stichwortInputText.text; //Ändern des Textes in wasauchimmer in s getippt wurde
    }
    public void checkStichwort()
    {
        
        if(b=="Freistellung")
        {
            uiController.updateStichwortAnzeigeText("YEAH!!!! mit diesem Stichwort komm ich hier auf alle Fälle weiter, " +
                                                    "im §37 Abs.2 sollte mehr dazu stehen");
        }
        else
        {
            if(b==null)
            {
                uiController.updateStichwortAnzeigeText("Dusolltest schon was eingeben");
            }
            uiController.updateStichwortAnzeigeText("nooo!");
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}

