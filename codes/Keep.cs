using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keep : MonoBehaviour
{
    public GameObject coin;
    public GameObject pogs;
    public GameObject sell;
    public GameObject jornual;
    // Start is called before the first frame update
    void Start()
    {
        //set up the buttun
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(keep);
    }

    // this will send the image to the book for it keep. it will also add in check varible for the pog case to appear again.
    // this function will start when the button is click.
    void keep()
    {
        // tells the button do not appear yet.
        pogs.GetComponent<POGS>().clicks = 0;
        // when the pogs button reach a certain amount of checks it will appear.
        pogs.GetComponent<POGS>().checks();
        //Any coin/pog that you decide to keep will be added to the list in the book collections
        jornual.GetComponent<books>().collectionbuild(coin);
        sell.SetActive(false);
        // set the coin to disappaer
        coin.SetActive(false);
        // set itself to be invisble.
        gameObject.SetActive(false);
    }
}
