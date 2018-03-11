using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetection : MonoBehaviour {

    public GameFlowController flowController;
    public _GameUIController uiController;
    public GameObject position;
    public UnityEngine.UI.Text mouseOverText;
    public Animator textbox;
    public GameObject gOb;
    public PhoneCoroutine bRTelephone;
    public string b;


	
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
        Debug.Log("ClickCLickClick");
        if(flowController.GetComponent<GameFlowController>().wasTalking == false)
        {    
        mouseOverText.text = null;
        StartCoroutine(textboxCoroutine());
        }
        else
        {
            StartCoroutine(textbox2Coroutine());  
        }


	}

    public IEnumerator textboxCoroutine()
    {
        gOb.SetActive(true);
        flowController.wasTalking = true;
        textbox.GetComponent<Animator>();
        StartCoroutine(bRTelephone.bRTelephone());
        yield break;
    }
    public IEnumerator textbox2Coroutine()
    {
        gOb.SetActive(true);
        textbox.GetComponent<Animator>();
        StartCoroutine(bRTelephone.bRTelephone2());
        yield break;
    }

}
