using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class TriggerHelper : MonoBehaviour
{

    public Image image;
    public Trigger[] t;
    public string s = "default";
    private int clickCount = 0;
    public TextMeshProUGUI text;

    
    void Awake()
    {
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) clickCount++;

        if (Array.Exists (t, element =>
        {
            if (element.t == true)
            {
                s = element.s;
                return true;
            }
            return false;
        }) && clickCount > 0)
        {
            switch(s)
            {
                case "scene": 
                    SceneManager.LoadScene("QuizQuestion1");
                break;
                default: 
                    image.enabled = true;
                    text.text = s;
                break;
            }
        }
        else
        {
            image.enabled = false;
            clickCount = 0;
            text.text = "";

        }
    }
}
