using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneBehavior : MonoBehaviour

{
    public _GameUIController uIController;
    public Animator phoneAnimator;
    public Animator playerBubble;
    public Animator phoneBubble;
    public Animator maxBubble;

    public UnityEngine.UI.Text playerActionText;
    public UnityEngine.UI.Text phoneText;
    public UnityEngine.UI.Text maxText;

    public GameObject player;
    public GameObject phone;
    public GameObject max;

    public UnityEngine.UI.Button arrow;

    public SoundController sounds;
    public bool wasTalking = false;
    public int anklingeln = 0;


	/* WAS TUT DAS SCRIPT? 
	 * TEIL1 - Die Routine 
	 * Start der Telephone Coroutine on Start.
	 * ZU Begin soll geprüft werden, ob die Gesprächgeführt?-Variable falsch ist.
	 * ist sie es, dann soll die Animationsvariable isRinging entsprechend gesetzt werden und der Sound
	 * abgespielt
	 * nach 10 Sekunden soll Animation beendet und Sound gestoppt werden
	 * es soll gezählt werden, wie oft dieser Vorgang bereits wiederholt wurde und i++
	 * dann soll für 30s pausiert werden
	 * alle 3 mal klingeln soll ein Text Animiert werden, um den Spieler zu bewegen das scheiß Telefon zu benutzen!
	 * "Boah das Telefon nervt ja heute, vielleicht sollte ich mal rangehen?"
	 * int soll resettet werden
	 * Wenn der Spieler auf das Telefon klickt, während es nicht klingelt und das Gespräch noch nicht geführt worden sein, soll vor der Animation die Ichzeile:
	 * „Ahh der BR hat versucht mich anzurufen, am besten ich rufe zurück…“ dann Start der Gesprächsmethode
	 * erscheinen
	 * Wenn der Spieler auf das Telefon klickt, während es klingelt, starte Gesprächsanimation
	 * wenn der Spieler das Gespräch geführt hatte, soll die Gesprächgeführt-Variable auf wahr gesetzt werden und die Routine beendet
	 * Wenn der Spieler auf das Telefon klickt und das Gespräch schon Geführt wurde
	 * "Wen bitte soll ich jetzt anrufen?"
	 * 
	 * Wenn auf Max geklickt wird und das Gespräch noch nicht geführt wurde, soll der einen Text bringen (Bubblehochfahren und so)
    */






    /*WAS TUT ES?
     * TEIL2 - Die Gesprächsmethode
     * Variable der Bubble (UP) anschalten, die Bubble visible Schalten, Textreinhauen, Variable ausschalten und unsichtbar machen.
     * PlayerAnimation auf isTalking = true
     *Bubble des Telephones ähnlich
     */


}
