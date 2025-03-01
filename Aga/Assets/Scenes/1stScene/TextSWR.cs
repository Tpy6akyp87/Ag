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
    public Button button1;
    public Button button2;
    public Button button3;
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
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button3.gameObject.SetActive(true);
        text.text = txts[0];
        textB1.text = txts[1];
        if (txts.Length == 4)
        {
            textB2.text = txts[2];
            textB3.text = txts[3];
        }
        if (txts.Length == 3)
        {
            textB2.text = txts[2];
            button3.gameObject.SetActive(false);
        }
        if (txts.Length == 2)
        {
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
        }
    }
}
