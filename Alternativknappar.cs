using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Alternativknappar : MonoBehaviour
{
    private Frågor frågor;
    public Color rättfärg = Color.green;
    public Color felfärg = Color.red;
    public void pressed()
    {
        frågor.Alternativ1[0].GetComponent<Image>().color = rättfärg;
        frågor.Alternativ2[0].GetComponent<Image>().color = felfärg;
    }
    // Start is called before the first frame update
    void Start()
    {
        Frågor frågor = GetComponent<Frågor>();
    }

    // Update is called once per frame
    void Update()
    {
        frågor.Alternativ1[frågor.index].SetActive(true);
        frågor.Alternativ2[frågor.index].SetActive(true);
    }
}
