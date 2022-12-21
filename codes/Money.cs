using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    // count up the money that it have earn
    public int money;
    public GameObject textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // show the user the money they have collected.
        textMeshPro.GetComponent<TMPro.TextMeshProUGUI>().text = "Money: " + money;
    }
}
