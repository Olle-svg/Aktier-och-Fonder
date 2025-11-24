using UnityEngine;

public class changeside : MonoBehaviour
{
    public GameObject Startpanel;
    public GameObject Aktiepanel;
    public GameObject Fondpanel;
    public GameObject Quizpanel;

    public void switchpaneltoaktie()
    {
        if (Startpanel != null)
            Startpanel.SetActive(false);
        if (Aktiepanel != null)
            Aktiepanel.SetActive(true);
    }
    public void switchpaneltofond()
    {
        if (Startpanel != null)
            Startpanel.SetActive(false);
        if (Fondpanel != null)
            Fondpanel.SetActive(true);
    }
    public void switchaktiepaneltostart()
    {
        if (Aktiepanel != null)
            Aktiepanel.SetActive(false);
        if (Startpanel != null)
            Startpanel.SetActive(true);
    }
    public void switchfondpaneltostart()
    {
        if (Fondpanel != null)
            Fondpanel.SetActive(false);
        if (Startpanel != null)
            Startpanel.SetActive(true);
    }
    public void switchpaneltoquiz()
    {
        if (Startpanel != null)
            Startpanel.SetActive(false);
        if (Quizpanel != null)
            Quizpanel.SetActive(true);
    }
}