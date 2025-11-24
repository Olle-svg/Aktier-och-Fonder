using UnityEngine;
using UnityEngine.UI;

public class Frågor : MonoBehaviour
{
    [SerializeField] public GameObject[] Alternativ1;
    [SerializeField] public GameObject[] Alternativ2;
    public Color orginal = Color.gray;
    [SerializeField] private GameObject[] frågor;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void högerknapp()
    {
        if (index < frågor.Length - 1)
        {
            frågor[index].SetActive(false);
            Alternativ1[index].SetActive(false);
            Alternativ2[index].SetActive(false);
            index += 1;
            Alternativ1[index].GetComponent<Image>().color = orginal;
            Alternativ2[index].GetComponent<Image>().color = orginal;
        }
    }
    public void vänsterknapp()
    {
        if (index > 0)
        {
            frågor[index].SetActive(false);
            Alternativ1[index].SetActive(false);
            Alternativ2[index].SetActive(false);
            index -= 1;
            Alternativ1[index].GetComponent<Image>().color = orginal;
            Alternativ2[index].GetComponent<Image>().color = orginal;
        }
    }

    // Update is called once per frame
    void Update()
    {
        frågor[index].SetActive(true);
    }
}
