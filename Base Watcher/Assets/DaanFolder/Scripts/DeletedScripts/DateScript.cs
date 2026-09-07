using System;
using UnityEngine;

public class DateScript : MonoBehaviour
{



    


    //public DateTime randomdateTime { get; set; } // a DateTime variable that is used to check the date and time of the level


    



    //public void dateChecker()
    //{
    //    randomdateTime = new DateTime(UnityEngine.Random.Range(2024, 2028), UnityEngine.Random.Range(1, 13), UnityEngine.Random.Range(1, 29)); // set the random date and time to a random date and time between January 1, 2024 and December 31, 2027
    //    Debug.Log("Random Date: " + randomdateTime); // print the random date and time to the console

    //    if (randomdateTime < DateTime.Now) // check if the date and time is less than the current date and time
    //    {
    //        Debug.Log("Date is in the past"); // print to the console that the date is in the past
    //        GetComponent<LevelButton>().denied = true; // set the passed variable of the LevelButton script to true
    //    }
    //    else if (randomdateTime > DateTime.Now) // check if the date and time is greater than the current date and time
    //    {
    //        Debug.Log("Date is in the future"); // print to the console that the date is in the future
    //        GetComponent<LevelButton>().passed = true; // set the passed variable of the LevelButton script to true
    //        GetComponent<LevelButton>().Pass(); // set the denied variable of the LevelButton script to true
    //    }
    //    else
    //    {
    //        Debug.Log("Date is now"); // print to the console that the date is now
    //        GetComponent<LevelButton>().passed = true; // set the passed variable of the LevelButton script to true
    //        GetComponent<LevelButton>().Pass(); // set the denied variable of the LevelButton script to true
    //    }
    //}



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //dateChecker(); // call the dateChecker function to check the date and time
    }



    //public void TimeChecker()
    //{
    //    if (randomdateTime < DateTime.Now)
    //    {
    //        Debug.Log("Time is in the past"); // print to the console that the time is in the past
    //    }
    //    else if (randomdateTime > DateTime.Now)
    //    {
    //        Debug.Log("Time is in the future"); // print to the console that the time is in the future
    //    }
    //    else
    //    {
    //        Debug.Log("Time is now"); // print to the console that the time is now
    //    }
    //}





    //public void RandomDatePicker()
    //{
    //    DateTime dateTime = DateTime.Now;
    //    Debug.Log("Current Date: " + dateTime); // print the current date and time to the console
    //}


    //// Update is called once per frame
    //void Update()
    //{
        
    //}







}
