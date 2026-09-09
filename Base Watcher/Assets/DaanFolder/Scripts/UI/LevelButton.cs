using System;
using System.Xml.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{

    #region Variables

    [Header("Bools")]
    public bool next; // a boolean variable that is used to check if the next button is clicked or not

    [Header("Int")]
    public int points; // a integer variable that is used to check the points of the level


    [Header("Canvas")]
    public Canvas gameOverCanvas; // a Canvas variable that is used to check if the game over canvas is active or not

    [Header("Text")]
    public Text text; // a TextMeshPro variable that is used to check the text of the level
    public Text dateText; // a TextMeshPro variable that is used to check the date and time of the level

    public TextMeshProUGUI ExpireDate; // a TextMeshPro variable that is used to check the expire date of the level

    [Header("Animation")]
    public Animator animator; // a Animator variable that is used to check the animator of the level

    public DateTime randomdateTime { get; set; } // a DateTime variable that is used to check the date and time of the level

    [Header("GameObjects")]
    public GameObject NPC;


    [Header("Scripts")]
    [SerializeField] IDScript IdScript;
    [SerializeField] NPCSpawner Spawner;


    #endregion

    #region Button Variables

    public void Pass() // a void function that is called when the Pass is clicked
    {
        if (IdScript.passed == true)
        {
            Debug.Log("Passed is true");

            points++;
            Debug.Log(points);
            text.text = "Points: " + points; // update the text of the level to show the points
            //animator.SetBool("Passed", true); // set the animator to play the passed animation when the pass button is clicked and the level is passed
            //DateChecker(); // call the dateChecker function to check the date and time of the level
        }
        Debug.Log("Pass Button Clicked"); // print to the console that the button was clicked

        if (IdScript.passed == false)
        {
            Debug.Log("It is denied");

            points = 0;
            Debug.Log("Wrong Button!!");
            //gameOverCanvas.gameObject.SetActive(true); // set the game over canvas to active when the deny button is clicked and the level is denied
            //DateChecker(); // call the dateChecker function to check the date and time of the level

        }
    }



    public void Deny() // a void function that is called when the Deny is clicked
    {
        if (IdScript.denied == true)
        {
            Debug.Log("Denied is true");
            points++;
            //animator.SetBool("Denied", true); // set the animator to play the passed animation when the pass button is clicked and the level is passed
            //DateChecker(); // call the dateChecker function to check the date and time of the level

        }
        if (IdScript.denied == false)
        {
            points = 0;
            Debug.Log("Wrong Button!!");
            Spawner.npcCount = 0;
            ///gameOverCanvas.gameObject.SetActive(true); // set the game over canvas to active when the deny button is clicked and the level is denied
            //GetComponent<NPCSpawner>().npcCount = 0; // reset the npcCount to 0 when the pass button is clicked and the level is passed
            Debug.Log("It is Pass");


        }
        Debug.Log("Deny Button Clicked"); // print to the console that the button was clicked
    }

    #endregion

    #region Button Pressed Functions
    public void ButtonPressed()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "PassButton")
        {
            Pass();
            //Destroy(NPC); // destroy the NPC when the pass button is clicked and the level is passed
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "DenyButton")
        {
            Deny();
            //Destroy(NPC); // destroy the NPC when the deny button is clicked and the level is denied
        }


    }



    public void NextButton()
    {
        //passed = false; // set the passed variable of the LevelButton script to false
        //denied = false; // set the denied variable of the LevelButton script to false

        //Debug.Log(passed); // print to the console that the button was clicked
        //Debug.Log(denied); // print to the console that the button was clicked

        Debug.Log("Button Pressed");
        GetComponent<NPCSpawner>().SpawnNPC(); // call the SpawnNPC function of the NPCSpawner script to spawn a new NPC when the next button is clicked
    }
    #endregion


    #region Update & start



    void Start()
    {
        gameOverCanvas.gameObject.SetActive(false); // set the game over canvas to inactive at the start of the game

    }



    void Update()
    {

    }

    #endregion

}