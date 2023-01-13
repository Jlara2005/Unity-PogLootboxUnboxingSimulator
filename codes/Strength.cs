using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Strength : MonoBehaviour
{
    public int level = 1;
    public GameObject Price;
    public int Plevel = 0;
    public GameObject levelmax;
    public GameObject levelmin;
    public bool max;
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(SUpgrade);
    }

    void Update()
    {
        // a check to make sure that the amount of clicks don't go over 5 or that will break the game.
        if (levelmax.GetComponent<POGS>().clicks + level - levelmin.GetComponent<Rarity>().level == 4)
        {
            max = true;
        } else
        {
            max = false;
        }
    }
    void SUpgrade()
    {
        //
        if (Price.GetComponent<Money>().money >= (level + Plevel) * 2 && max == false)
        {
            
            Price.GetComponent<Money>().money = Price.GetComponent<Money>().money - (level + Plevel) * 2;
            Plevel += level;
            level += 1;
        }
        
    }
}
