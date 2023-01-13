using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour
{
    public GameObject store;
    public GameObject storetext;
    public GameObject StrengthLabel;
    public GameObject RarityLabel;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Store);


        GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -265);
    }

    void Store()
    {
        if (GetComponent<RectTransform>().anchoredPosition.y == -265)
        {
            storetext.GetComponent<TMPro.TextMeshProUGUI>().text = "Close";
            store.SetActive(true);
            StrengthLabel.SetActive(true);
            RarityLabel.SetActive(true);
            GetComponent<RectTransform>().anchoredPosition = new Vector2(230, 31);
        }
        else
        {
            store.SetActive(false);
            StrengthLabel.SetActive(false);
            RarityLabel.SetActive(false);
            GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -265);
            storetext.GetComponent<TMPro.TextMeshProUGUI>().text = "Store";
        }
    }
}

