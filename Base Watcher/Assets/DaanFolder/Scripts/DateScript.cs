using System;
using UnityEngine;

public class DateScript : MonoBehaviour
{







    public DateTime dateTime; // a DateTime variable that is used to check the date and time of the level








    public void dateChecker()
    {
        if (dateTime < DateTime.Now) // check if the date and time is less than the current date and time
        {
            Debug.Log("Date is in the past"); // print to the console that the date is in the past
        }
        else if (dateTime > DateTime.Now) // check if the date and time is greater than the current date and time
        {
            Debug.Log("Date is in the future"); // print to the console that the date is in the future
        }
        else
        {
            Debug.Log("Date is now"); // print to the console that the date is now
        }

    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dateChecker();
    }








    // Update is called once per frame
    void Update()
    {
        Debug.Log(DateTime.Now); // print the current date and time to the console
    }







}
