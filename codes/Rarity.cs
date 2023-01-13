using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Rarity : MonoBehaviour
{
    public int level = 1;
    public GameObject Price;
    public int Plevel = 0;
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(RUpgrade);
    }

    // Update is called once per frame
    void RUpgrade()
    {
        if (Price.GetComponent<Money>().money >= (level + Plevel) * 2)
        {
            
            Price.GetComponent<Money>().money = Price.GetComponent<Money>().money - (level + Plevel) * 2;
            Plevel += level;
            level += 1;
        }
        
    }
}
