using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizknapp : MonoBehaviour
{
    public GameObject Knapp;
    public GameObject Quiz;

    public void Press()
    {
        if (Knapp != null)
            Knapp.SetActive(false);
        if (Quiz != null)
            Quiz.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
