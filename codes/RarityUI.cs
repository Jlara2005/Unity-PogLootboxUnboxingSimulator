using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RarityUI : MonoBehaviour
{
    public GameObject Rlevel;
    public GameObject Rcost;
    public GameObject info;

    // Update is called once per frame
    void Start()
    {
        Rcost.GetComponent<TMPro.TextMeshProUGUI>().text = "Cost: " + (info.GetComponent<Rarity>().level + info.GetComponent<Rarity>().Plevel) * 2;
        Rlevel.GetComponent<TMPro.TextMeshProUGUI>().text = "Level: " + info.GetComponent<Rarity>().level;
    }
    void Update()
    {
        Rcost.GetComponent<TMPro.TextMeshProUGUI>().text = "Cost: " + (info.GetComponent<Rarity>().level + info.GetComponent<Rarity>().Plevel) * 2;
        Rlevel.GetComponent<TMPro.TextMeshProUGUI>().text = "Level: " + info.GetComponent<Rarity>().level;
    }
}

