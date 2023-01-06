using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Store);


        GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -265);
    }

    // Update is called once per frame
    void Store()
    {
        if (GetComponent<RectTransform>().anchoredPosition.y == -265);
        {
            GetComponent<RectTransform>().anchoredPosition = new Vector2(230, 31);
        }   else
        {
            GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -265);
        }
    }
}

