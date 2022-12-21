using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class left : MonoBehaviour
{
    public GameObject bookpages;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(turnleft);
    }

    // When this button is click this function appear. It change the page number you on. the reason it change it by 8 instead of 1 is an list is using this varible. there is no negative page 
    void turnleft()
    {
        if (bookpages.GetComponent<books>().pagenumber != 0)
        {
            bookpages.GetComponent<books>().pagenumber -= 8;
            bookpages.GetComponent<books>().pageturn();
        }
    }
}
