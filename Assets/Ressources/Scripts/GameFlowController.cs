using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlowController : MonoBehaviour
{

    public _GameUIController uiController;
    public SoundController sounds;
    public MusicController music;
    public Animator phone;
    public Animator max;
    public Animator animBox;
    public GameObject textBox;


    public int lvl = 1;
    public int i;
    public bool wasTalking = false;
    private bool isRunning = false;

    //public Node currentNode; // Übertragenes Problem aus Node.cs: Der Collider der Location könnte den Collider des Props überlagern

    void Awake()
    {
        //Statische Referenz setzen (bad singleton)

    }
    // Use this for initialization
    void Start()
    {
        StartCoroutine(startNewRound());
    }

    // Update is called once per frame
    void Update()
    {
        if (wasTalking == false && isRunning == false)
        {
            StartCoroutine(startNewRound());
        }

        if (wasTalking == true)
        {
            sounds.phone.Stop();
            StopAllCoroutines();

        }

    }



    //Begin der Anfangscoroutine

    public IEnumerator startNewRound()
    {
        yield return StartCoroutine(startAnimationCoroutine());
        //Irgendwas
    }

    public IEnumerator startAnimationCoroutine()
    {
        if (wasTalking == false)
        {
            if (i <= 1)
            {
                i++;
                isRunning = true;
                sounds.phone.Play();
                phone.GetComponent<Animator>().SetBool("isRinging", true);
                yield return new WaitForSeconds(10);
                sounds.phone.Stop();
                phone.GetComponent<Animator>().SetBool("isRinging", false);
                yield return new WaitForSeconds(10);
                isRunning = false;

                yield break;
            }
            if (i > 1 && i < 3)
            {
                i++;
                isRunning = true;
                sounds.phone.Play();
                phone.GetComponent<Animator>().SetBool("isRinging", true);
                max.GetComponent<Animator>().SetBool("isSad", true);
                yield return new WaitForSeconds(10);
                sounds.phone.Stop();
                phone.GetComponent<Animator>().SetBool("isRinging", false);
                max.GetComponent<Animator>().SetBool("isSad", false);
                yield return new WaitForSeconds(10);
                isRunning = false;
                yield break;
            }
            if (i == 3)
            {
                i++;
                isRunning = true;
                sounds.phone.Play();
                phone.GetComponent<Animator>().SetBool("isRinging", true);
                max.GetComponent<Animator>().SetBool("isSad", true);
                textBox.SetActive(true);
                uiController.updateActionText("<color=green> Max:  </color>" +
                                              "\n Jetzt lass doch nicht immer durchklingeln und GEH RAN!");
                yield return new WaitForSeconds(5);
                sounds.phone.Stop();
                uiController.updateActionText("");
                animBox.GetComponent<Animator>().SetBool("boxDown", true);
                textBox.SetActive(false);
                phone.GetComponent<Animator>().SetBool("isRinging", false);
                max.GetComponent<Animator>().SetBool("isSad", false);
                yield return new WaitForSeconds(10);
                isRunning = false;
                yield break;
            }
        }
        if (i > 3)
        {
            i++;
            isRunning = true;
            sounds.phone.Play();
            phone.GetComponent<Animator>().SetBool("isRinging", true);
            max.GetComponent<Animator>().SetBool("isSad", true);
            textBox.SetActive(true);
            uiController.updateActionText(" < color = green > Max:  </ color > " +
                                          "\n Das mit dem Spiel hast du wohl eher nicht kapiert, oder? Click auf das Phone");
            yield return new WaitForSeconds(5);
            sounds.phone.Stop();
            uiController.updateActionText("");
            animBox.GetComponent<Animator>().SetBool("boxDown", true);
            textBox.SetActive(false);
            phone.GetComponent<Animator>().SetBool("isRinging", false);
            max.GetComponent<Animator>().SetBool("isSad", false);
            yield return new WaitForSeconds(10);
            isRunning = false;
            yield break;
        }




    }
}
