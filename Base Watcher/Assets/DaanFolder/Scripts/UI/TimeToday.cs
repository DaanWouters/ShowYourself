using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeToday : MonoBehaviour
{

    #region Variables
    public Text timeText; // a Text variable that is used to check the text of the time
    #endregion

    #region Update Function
    void Update()
    {
        Date(); // call the Date function to check the date and time
    }
    #endregion

    #region Date Function

    public void Date()
    {
        DateTime dateTime = DateTime.Now; // get the current date and time
        timeText.text = dateTime.ToString("yyyy:MM:dd"); // update the text of the time to show the current date and time in the format of "yyyy:MM:dd"
    }
    #endregion

}
