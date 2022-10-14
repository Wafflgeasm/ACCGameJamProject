using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class ButtonScript : MonoBehaviour
{
    public bool isDark;
    public ButtonType type;
    public TextMeshProUGUI text;
    bool isInitted;
    Action onClick;
    public void Init(Action onClick, string text){

        this.onClick = onClick;
        this.isInitted = true;
        this.text.text = text;
    }
    void Start()
    {
        if (!isInitted){
            Debug.LogError("Not Initted");
        }
    }
    public enum ButtonType{
        OneByFour,
    }
}
