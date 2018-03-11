using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchubClickDetection : MonoBehaviour {

    public GameFlowController flowController;
    public _GameUIController uiController;
    public GameObject position;
    public UnityEngine.UI.Text mouseOverText;
    public Animator textbox;
    public GameObject gOb;
    public SchubCoroutine schubCoroutine;
    public string b;
    private bool did = false;



    void OnMouseOver()
    {
        Debug.Log("Mouse over GameObject");

        mouseOverText.text = b;
        mouseOverText.transform.position = position.transform.position;

    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is not! over GameObject");
        mouseOverText.text = null;
    }

    void OnMouseDown()
    {
        if (flowController.GetComponent<GameFlowController>().wasTalking)
        {
            mouseOverText.text = null;
            StartCoroutine(textboxCoroutine());
            did = true;

        }
        else
        {
            if (did == true)

            {
                mouseOverText.text = "Da drin ist nix mehr von Nutzen!";
                textbox2();
            }
        }
    }

    public IEnumerator textboxCoroutine()
    {
        gOb.SetActive(true);
        textbox.GetComponent<Animator>();
        StartCoroutine(schubCoroutine.coroutine1());
        yield break;
    }
    void textbox2()
    {
        mouseOverText.text = "Da drin ist wirklich nichts brauchbares mehr.";

    }



}
