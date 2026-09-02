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



    public bool passed; // a boolean variable that is used to check if the level is passed or not
    public bool denied; // a boolean variable that is used to check if the level is denied or not
    public int points; // a integer variable that is used to check the points of the level
    
    public Canvas gameOverCanvas; // a Canvas variable that is used to check if the game over canvas is active or not

    public Text text; // a TextMeshPro variable that is used to check the text of the level

    public Animator animator; // a Animator variable that is used to check the animator of the level
    #endregion


    #region Button Variables

    public void Pass() // a void function that is called when the Pass is clicked
    {
        if (passed)
        {
            points++;
            Debug.Log(points);
            text.text = "Points: " + points; // update the text of the level to show the points
            animator.SetBool("Passed", true); // set the animator to play the passed animation when the pass button is clicked and the level is passed
        }
        Debug.Log("Pass Button Clicked"); // print to the console that the button was clicked

        if (!passed)
        {
            points = 0;
            Debug.Log("Wrong Button!!");
            gameOverCanvas.gameObject.SetActive(true); // set the game over canvas to active when the deny button is clicked and the level is denied

        }
    }

    public void Deny() // a void function that is called when the Deny is clicked
    {
        if(denied)
        {
            points++;
            animator.SetBool("Denied", true); // set the animator to play the passed animation when the pass button is clicked and the level is passed

        }
        if (!denied)
        {
            points = 0;
            Debug.Log("Wrong Button!!");
            gameOverCanvas.gameObject.SetActive(true); // set the game over canvas to active when the deny button is clicked and the level is denied



        }
        Debug.Log("Deny Button Clicked"); // print to the console that the button was clicked
    }

    #endregion


    #region Update & start


    void Start()
    {
        gameOverCanvas.gameObject.SetActive(false); // set the game over canvas to inactive at the start of the game

    }



    void Update()
    {


        if (passed)
        {
            Debug.Log("Passed");
        }
        if (denied)
        {
            Debug.Log("Denied");
        }
        else
        {
            Debug.Log("Nothing yet");
        }
    }

    #endregion


}
