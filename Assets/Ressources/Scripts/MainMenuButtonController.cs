using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


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

    public void showStartPage()
    {
        startPageUI.SetActive(true);
    }

 
    public void playGame() //Startet erste Gameszene mit Namen GameScene. Muss erst mit ins Build, damit es funzt!
    {
        SceneManager.LoadScene("GameScene");
        startPageUI.SetActive(false);

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