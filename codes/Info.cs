using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Info : MonoBehaviour
{
    
    public void dictionary(string Pogs)
    {
        Regex CPpog = new Regex(@"CP", RegexOptions.Singleline);
        Debug.Log(Pogs);
        Debug.Log(CPpog.IsMatch(Pogs));
        //try to make it compare sprite
        switch (Pogs)
        {
            case "fsaf":
                break;
        }
    }
}
