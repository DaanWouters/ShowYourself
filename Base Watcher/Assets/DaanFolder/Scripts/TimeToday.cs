using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeToday : MonoBehaviour
{
    public Text timeText; // a Text variable that is used to check the text of the time


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime dateTime = DateTime.Now;
        timeText.text = dateTime.ToString("yyyy:MM:dd");
    }
}
