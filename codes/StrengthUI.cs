using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthUI : MonoBehaviour
{
    public GameObject Slevel;
    public GameObject Scost;
    public GameObject info;

    // Update is called once per frame
    void Start()
    {
        Scost.GetComponent<TMPro.TextMeshProUGUI>().text = "Cost: " + (info.GetComponent<Strength>().level + info.GetComponent<Strength>().Plevel) * 2;
        Slevel.GetComponent<TMPro.TextMeshProUGUI>().text = "Level: " + info.GetComponent<Strength>().level;
    }
    // it shows the details of the cost of the upgrade and it level.
    void Update()
    {
        if (info.GetComponent<Strength>().max == true)
        {
            Scost.GetComponent<TMPro.TextMeshProUGUI>().text = "Cost: MAX";
        } else
        {
            Scost.GetComponent<TMPro.TextMeshProUGUI>().text = "Cost: " + (info.GetComponent<Strength>().level + info.GetComponent<Strength>().Plevel) * 2;
        }
        
        Slevel.GetComponent<TMPro.TextMeshProUGUI>().text = "Level: " + info.GetComponent<Strength>().level;
    }
}
