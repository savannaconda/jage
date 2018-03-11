using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



/* Dieser Controller sorgt dafür, dass die Interaktion zwischen den einzelnen 
 * Spielbildschirmen innerhalb einer Szene und die Weiterleitung zur ersten Gameszene 
 * gewährleistet wird. 
 */


public class MainMenuButtonController : MonoBehaviour
{
    /*Funktion Zeigt die startPage an, 
     * hier kann der Spieler seinen 
     * Nick eingeben, die Gesetzesgrundlage wählen und Krams
     */

    public GameObject startPageUI;
    public GameObject BetrVG;
    public GameObject Stichwort;
    public GameObject Kapitel;
    public GameObject Paragraph;
    public GameObject Check;


#region Switch zwischen den UIs
    public void showStartPage()
    {
        startPageUI.SetActive(true);
        BetrVG.SetActive(false);
        Stichwort.SetActive(false);
        Kapitel.SetActive(false);
        Paragraph.SetActive(false);
        Check.SetActive(false);
    }
    public void showBetrVG()
    {
        startPageUI.SetActive(false);
        BetrVG.SetActive(true);
        Stichwort.SetActive(false);
        Kapitel.SetActive(false);
        Paragraph.SetActive(false);
        Check.SetActive(false);
    }
    public void showKapitel()
    {
        startPageUI.SetActive(false);
        BetrVG.SetActive(false);
        Stichwort.SetActive(false);
        Kapitel.SetActive(true);
        Paragraph.SetActive(false);
        Check.SetActive(false);
    }
    public void showParagraph()
    {
        startPageUI.SetActive(false);
        BetrVG.SetActive(false);
        Stichwort.SetActive(false);
        Kapitel.SetActive(false);
        Paragraph.SetActive(true);
        Check.SetActive(false);
    }
    public void showStichwort()
    {
        startPageUI.SetActive(false);
        BetrVG.SetActive(false);
        Stichwort.SetActive(true);
        Kapitel.SetActive(false);
        Paragraph.SetActive(false);
        Check.SetActive(false);
    }
    public void showCheck()
    {
        startPageUI.SetActive(false);
        BetrVG.SetActive(false);
        Stichwort.SetActive(false);
        Kapitel.SetActive(false);
        Paragraph.SetActive(false);
        Check.SetActive(true);
    }
#endregion

    public void playGame() //Startet erste Gameszene mit Namen GameScene. Muss erst mit ins Build, damit es funzt!
    {
        SceneManager.LoadScene("GameScene");
    }
    public void quitGame() //Beendet die Applikation
    {
        Application.Quit();
    }


        /* überprüft, ob Username eingegeben wurde und 
         * speichert diesen ggf. in den string s
         * wird dann vom Script username, an entsprechendem Textobjekt ausgelesen.
         */


}