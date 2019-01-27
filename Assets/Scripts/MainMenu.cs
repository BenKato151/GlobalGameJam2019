using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject play;
    public GameObject help;
    public GameObject credits;
    public GameObject quit;

    public GameObject helpPage;
    public GameObject creditsPage;

    public GameObject back;

    public void Help()
    {
        play.SetActive(false);
        help.SetActive(false);
        credits.SetActive(false);
        quit.SetActive(false);

        helpPage.SetActive(true);
        creditsPage.SetActive(false);

        back.SetActive(true);
    }

    public void Credits()
    {
        play.SetActive(false);
        help.SetActive(false);
        credits.SetActive(false);
        quit.SetActive(false);

        helpPage.SetActive(false);
        creditsPage.SetActive(true);

        back.SetActive(true);
    }

    public void Back()
    {
        play.SetActive(true);
        help.SetActive(true);
        credits.SetActive(true);
        quit.SetActive(true);

        helpPage.SetActive(false);
        creditsPage.SetActive(false);

        back.SetActive(false);
    }

    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}