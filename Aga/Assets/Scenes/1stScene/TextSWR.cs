using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TextSWR : MonoBehaviour
{
    public string[] dialogText1;
    public string[] dialogText2;
    public string[] dialogText3;
    public TMP_Text text;
    public TMP_Text textB1;
    public TMP_Text textB2;
    public TMP_Text textB3;
    // Start is called before the first frame update
    void Start()
    {
        TextChoice(dialogText1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WTF(int t) 
    {
        switch (t)
        {    
            case 0: TextChoice(dialogText1); break;
            case 1: TextChoice(dialogText2); break;
            case 2: TextChoice(dialogText3); break;
        }
    }
    public void TextChoice(string[] txts)
    {
        text.text = txts[0];
        textB1.text = txts[1];
        textB2.text = txts[2];
        textB3.text = txts[3];
    }
}
