using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class POGS : MonoBehaviour
{
    // the max should change to the amount of pogs in the pog list
    int max = 3;
    //Show how much the pog case have been click
    public int clicks = 0;
    // all gameobject below is the coin and button that will appear after the pog case is click on
    public GameObject sell;
    public GameObject keep;
    public GameObject sell2;
    public GameObject keep2;
    public GameObject sell3;
    public GameObject keep3;
    public GameObject sell4;
    public GameObject keep4;
    public GameObject coin;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    // check make sure that each coin have been check on
    public int check = 1;
    // This is the list of all image that have been added to the pogs list
    public Sprite[] pogList;
    // to etablish the chance which randomly pick out a pog from the pog list
    int chance;
    // Start is called before the first frame update
    void Start()
    {
        // set up the button
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(POGSCLICK);
    }

    // Starts every time the button is click
    void POGSCLICK()
    {
        clicks++;
        if (clicks == 5)
        {
            // will randomly pick out a random image from the pog list
            chance = Random.Range(0, max);
            // show every option that is use for the pogs.
            sell.SetActive(true);
            keep.SetActive(true);
            sell2.SetActive(true);
            keep2.SetActive(true);
            sell3.SetActive(true);
            keep3.SetActive(true);
            sell4.SetActive(true);
            keep4.SetActive(true);
            coin.SetActive(true);
            coin2.SetActive(true);
            coin3.SetActive(true);
            coin4.SetActive(true);
            //pick out a random image for the coin
            coin.GetComponent<Image>().sprite = pogList[chance];
            chance = Random.Range(0, max);
            coin2.GetComponent<Image>().sprite = pogList[chance];
            chance = Random.Range(0, max);
            coin3.GetComponent<Image>().sprite = pogList[chance];
            chance = Random.Range(0, max);
            coin4.GetComponent<Image>().sprite = pogList[chance];
            gameObject.SetActive(false);
        }
        
   
    }
    // when all the pogs have been taken care of. The function below will the pog capsule appear again.
    public void checks()
    {
        // if it reach a certain amount of checks from the sell or keep button. it will appear again
        if (check == 4)
        {
            check = 1;
            gameObject.SetActive(true);
        }
        else
        {
            check += 1;
        }
    }
}
