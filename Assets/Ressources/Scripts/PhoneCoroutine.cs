using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCoroutine : MonoBehaviour
{

    public _GameUIController uiController;
    public GameFlowController flowController;
    public string s;
    public Animator animBox;
    public GameObject textBox;


   void Start()
    {
        s = PlayerPrefs.GetString("playerName");
    }



    public IEnumerator bRTelephone()
    {



        {
            uiController.actionText.gameObject.SetActive(true);

            yield return new WaitForSeconds(1);

            uiController.updateActionText("<color=green> HANNES (BR-Vorsitz):  </color>" +
                                          "\n Hallo, " + s +
                                          "\n Klasse, dass ich dich endlich erreiche! \n habe da ein Anliegen an dich.");
            yield return new WaitForSeconds(5);
            uiController.updateActionText("<color=green> HANNES (BR-Vorsitz):  </color>" +
                                          "\n und zwar liegt mir euer Ausbilder, Bruno Gans nun seid Wochen in den Ohren." +
                                          "\n Er jammert und jammert, die Azubis würden ihre Berichtshefte einfach schlampig führen.");

            yield return new WaitForSeconds(5);
            uiController.updateActionText("<color=green> HANNES (BR-Vorsitz):  </color>" +
                                          "\n da dachte ich, das wär doch mal etwas, wo ihr als JAVis aktiv werden könntet.");

            yield return new WaitForSeconds(10);
            uiController.updateActionText("<color=green> HANNES (BR-Vorsitz):  </color>" +
                                          "\n Ich habe dir einen GEsetzeskommentar in dein Schubfach gelegt." +
                                          "Das sollte für den Anfang reichen!" +
                                          "So! Ich muss mal weiter, die Pflicht ruft. Halt mich auf den Laufenden."
                                         );

            yield return new WaitForSeconds(5);
            uiController.updateActionText(" ");
            animBox.GetComponent<Animator>().SetBool("boxDown", true);
            textBox.SetActive(false);
            flowController.GetComponent<GameFlowController>().wasTalking = true;
            Debug.Log("switcht was Talking!");
            yield break;
        }



    }

    public IEnumerator bRTelephone2()
    {
        uiController.actionText.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        uiController.updateActionText("<color=green>Ich</color>" +
                                      "<i>Hmm...klingeln nur noch durch, schade. Dann muss ich wohl alleine Rausfinden, wie das mit der JAV Arbeit läuft." +
                                      "Vielleicht hilft mir das Gesetzesbuch weiter?</i>" 
                                     );

        yield return new WaitForSeconds(7);
        uiController.updateActionText(" ");
        animBox.GetComponent<Animator>().SetBool("boxDown", true);
        textBox.SetActive(false);
        yield break;
    }
}
