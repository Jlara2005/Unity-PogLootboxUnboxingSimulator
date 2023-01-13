using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class books : MonoBehaviour
{
    // book is panel that opens up and closes.
    public GameObject book;
    // it hide the book text to make it more like a tab to the book.
    public GameObject booktext;
    // page number should tell the program which page of pog should it use.
    public int pagenumber = 0;
    // this is all the pogs from your sprite that is currently on the pages.
    public GameObject[] collected = new GameObject[8];
    // Collection list sprite contains all the image that you have decided to keep .
    public List<Sprite> collection = new List<Sprite>();
    // it tells the list the amount of pogs that it already went through.
    int pogamount = 0;
    // When the left arrow is click it start the page turn function. it have a script called left.
    public GameObject leftarrow;
    // When the right arrow is click it start the page turn function. it have a script called right.
    public GameObject rightarrow;
    void Start()
    {
        // the orginal position that the button book should be 
        GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0);
        GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0);
        GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 11);
        //Debug.Log(Screen.width);
        // transform.localPosition = new Vector3(0, -244, 0);
        // tell the button that when it is click on. start the function bookclick
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(bookclick);
    }
    

    
    void bookclick()
    {
        if (GetComponent<RectTransform>().anchoredPosition.y == 25)
        {
            // put away the book by setting them inactive
            book.SetActive(false);
            // make the text appear 
            booktext.SetActive(true);
            //disable both arrows of the books
            leftarrow.SetActive(false);
            rightarrow.SetActive(false);
            // set each book pog to be invisble
            foreach (GameObject bookpog in collected)
            {
                bookpog.SetActive(false);
            }
            // move the book button to this location 
            GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0);
            GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0);
            GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 11);
        } else
        {
            // set the pogamount to zero
            pogamount = 0;
            // make the book apear
            book.SetActive(true);
            
            // hide the book text on the button
            booktext.SetActive(false);
            // make both arrows active
            leftarrow.SetActive(true);
            rightarrow.SetActive(true);
            // Go to each invisble pog pockets in the book. For each pog pocket we grab the image sprite and set it equal to the collected pog image sprite. 
            //Collection.count is the list version of Collection.length
            //pog amount will count up the available index of the collection pog.
            // pagenumber will count which page you are in 

            foreach (GameObject bookpog in collected)
            {
                if (collection.Count <= pogamount + pagenumber)
                {
                    // nothings happen in this if, only in the else
                   // bookpog.GetComponent<Image>().sprite = collection[pogamount + pagenumber].GetComponent<Image>().sprite;
                   // bookpog.SetActive(true);
                   // pogamount++;
                } else
                {
                    // set each invisble pog in the book and have them take the sprite from the whole pog list.
                    bookpog.GetComponent<Image>().sprite = collection[pogamount + pagenumber];
                     bookpog.SetActive(true);
                     pogamount++;
                }
            }
            // set the book button to the top of the book. simlier like a tab.
            GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 25);
        }

        
    }
    // everytime click button is press this command starts. it will collect the amount of pogs that we will be revcaiving.
    public void collectionbuild(GameObject keepcoin)
    {
        collection.Add(keepcoin.GetComponent<Image>().sprite);
    }
    // it scan for pogs everytime the arrows on either side is click
    public void pageturn()
    {
        pogamount = 0;
        foreach (GameObject bookpog in collected)
        {
            if (collection.Count <= pogamount + pagenumber)
            {
                bookpog.SetActive(false);
            }
            else
            {
                bookpog.GetComponent<Image>().sprite = collection[pogamount + pagenumber];
                bookpog.SetActive(true);
                pogamount++;
            }
        }
    }

}
