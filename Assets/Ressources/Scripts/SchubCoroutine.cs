using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchubCoroutine : MonoBehaviour
{

    public _GameUIController uiController;
    public GameFlowController flowController;
    public string s;
    public Animator animBox;
    public GameObject textBox;
    public SoundController sounds;
    public GameObject betrvg;





    void Start()
    {
        s = PlayerPrefs.GetString("playerName");
    }



    public IEnumerator coroutine1()
    {
        animBox.GetComponent<Animator>();
        animBox.GetComponent<Animator>().SetBool("boxUp", true);
        textBox.SetActive(true);
        yield return new WaitForSeconds(1);
        uiController.updateActionText("<color=green>Ich</color>" +
                                      "<i>\n Klasse, das ist ja das /TODO TOGGLE/ als Gesetzeskommentar! Da kann ich bestimmt nachschlagen, wie ich meine Arbeit machen kann. </i>");
        yield return new WaitForSeconds(7);
        uiController.updateActionText(" ");
        betrvg.SetActive(true);
        sounds.lettersound.Play();
        animBox.GetComponent<Animator>().SetBool("boxDown", true);
        textBox.SetActive(false);
    }

}

