using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{

    #region Variables

    public bool next; // a boolean variable that is used to check if the next button is clicked or not
    public bool passed; // a boolean variable that is used to check if the level is passed or not
    public bool denied; // a boolean variable that is used to check if the level is denied or not
    public int points; // a integer variable that is used to check the points of the level


    public Canvas gameOverCanvas; // a Canvas variable that is used to check if the game over canvas is active or not

    public Text text; // a TextMeshPro variable that is used to check the text of the level
    public Text dateText; // a Text variable that is used to check the date and time of the level


    public Animator animator; // a Animator variable that is used to check the animator of the level

    public DateTime randomdateTime { get; set; } // a DateTime variable that is used to check the date and time of the level

    public GameObject NPC;



    #endregion


    #region Button Variables

    public void Pass() // a void function that is called when the Pass is clicked
    {
        if (passed)
        {
            points++;
            Debug.Log(points);
            text.text = "Points: " + points; // update the text of the level to show the points
            //animator.SetBool("Passed", true); // set the animator to play the passed animation when the pass button is clicked and the level is passed
            DateChecker(); // call the dateChecker function to check the date and time of the level
        }
        Debug.Log("Pass Button Clicked"); // print to the console that the button was clicked

        if (!passed)
        {
            points = 0;
            Debug.Log("Wrong Button!!");
            gameOverCanvas.gameObject.SetActive(true); // set the game over canvas to active when the deny button is clicked and the level is denied
            DateChecker(); // call the dateChecker function to check the date and time of the level

        }
    }

    public void Deny() // a void function that is called when the Deny is clicked
    {
        if(denied)
        {
            points++;
            //animator.SetBool("Denied", true); // set the animator to play the passed animation when the pass button is clicked and the level is passed
            DateChecker(); // call the dateChecker function to check the date and time of the level

        }
        if (!denied)
        {
            points = 0;
            Debug.Log("Wrong Button!!");
            gameOverCanvas.gameObject.SetActive(true); // set the game over canvas to active when the deny button is clicked and the level is denied
            DateChecker(); // call the dateChecker function to check the date and time of the level


        }
        Debug.Log("Deny Button Clicked"); // print to the console that the button was clicked
    }

    #endregion


   public void ButtonPressed()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "PassButton")
        {
            Pass();
            Destroy(NPC); // destroy the NPC when the pass button is clicked and the level is passed
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "DenyButton")
        {
            Deny();
            Destroy(NPC); // destroy the NPC when the deny button is clicked and the level is denied
        }


    }




    public void NextButton()
    {
        passed = false; // set the passed variable of the LevelButton script to false
        denied = false; // set the denied variable of the LevelButton script to false

        Debug.Log(passed); // print to the console that the button was clicked
        Debug.Log(denied); // print to the console that the button was clicked

        if (next)
        {
            
        }
    }











    public void DateChecker()
    {
        randomdateTime = new DateTime(UnityEngine.Random.Range(2024, 2028), UnityEngine.Random.Range(1, 13), UnityEngine.Random.Range(1, 29)); // set the random date and time to a random date and time between January 1, 2024 and December 31, 2027
        Debug.Log("Random Date: " + randomdateTime); // print the random date and time to the console

        if (randomdateTime < DateTime.Now) // check if the date and time is less than the current date and time
        {
            //Debug.Log("Date is in the past"); // print to the console that the date is in the past
            denied = true; // set the passed variable of the LevelButton script to true
            passed = false; // set the denied variable of the LevelButton script to false


        }
        else if (randomdateTime > DateTime.Now) // check if the date and time is greater than the current date and time
        {
            //Debug.Log("Date is in the future"); // print to the console that the date is in the future
            passed = true; // set the passed variable of the LevelButton script to true
            denied = false; // set the denied variable of the LevelButton script to false
        }
        else
        {
            //Debug.Log("Date is now"); // print to the console that the date is now
            passed = true; // set the passed variable of the LevelButton script to true
            denied = false; // set the denied variable of the LevelButton script to false
        }

        if (passed)
        {
            randomdateTime = new DateTime(UnityEngine.Random.Range(2024, 2028), UnityEngine.Random.Range(1, 13), UnityEngine.Random.Range(1, 29)); // set the random date and time to a random date and time between January 1, 2024 and December 31, 2027
            Destroy(NPC); // destroy the NPC when the pass button is clicked and the level is passed

        }
        if (denied)
        {
         Debug.Log("Denied");   
            randomdateTime = new DateTime(UnityEngine.Random.Range(2024, 2028), UnityEngine.Random.Range(1, 13), UnityEngine.Random.Range(1, 29)); // set the random date and time to a random date and time between January 1, 2024 and December 31, 2027

        }


    }



    #region Update & start


    void Start()
    {
        gameOverCanvas.gameObject.SetActive(false); // set the game over canvas to inactive at the start of the game
        //GetComponent<DateScript>();
        DateChecker();
    }



    void Update()
    {
        //if (passed == true)
        //{
        //    Debug.Log("Passed");
        //}
        //if (denied)
        //{
        //    Debug.Log("Denied");
        //}
        //else
        //{
        //    Debug.Log("Nothing yet");
        //}

    }

    #endregion


}
