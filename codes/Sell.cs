using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sell : MonoBehaviour
{
    // grab the coin/pog data that they can affect. it usally above the button
    public GameObject coin;
    // it affect the button to make it reapper.
    public GameObject pogs;
    public GameObject keep;
    // grab the money counter object in the corner for editing the money count.
    public GameObject moneyob;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(sell);
    }

    // starts the sell function when the button is click.
    void sell()
    {
        // add the money to the money counter in the corner.
        moneyob.GetComponent<Money>().money++;
        // tells the button do not appear yet.
        pogs.GetComponent<POGS>().clicks = 0;
        // set the coin to disappaer
        coin.SetActive(false);
        // when the pogs button reach a certain amount of checks it will appear.
        pogs.GetComponent<POGS>().checks();
        // set the other option to disapepar
        keep.SetActive(false);
        // set itself to be invisble.
        gameObject.SetActive(false);
    }
}
