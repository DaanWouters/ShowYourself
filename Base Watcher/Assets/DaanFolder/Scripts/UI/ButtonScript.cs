using System;
using System.Xml.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    #region Variables

    [Header("Bools")]
    public bool next; // a boolean variable that is used to check if the next button is clicked or not
    //public bool passAnim;
    //public bool denyAnim;
    //public bool walkAnim;

    [Header("Int")]
    public int points; // a integer variable that is used to check the points of the level
    public int speed = 5;

    [Header("Canvas")]
    public Canvas gameOverCanvas; // a Canvas variable that is used to check if the game over canvas is active or not

    [Header("Text")]
    public Text text; // a TextMeshPro variable that is used to check the text of the level

    [Header("Animation")]
    public Animator animator; // a Animator variable that is used to check the animator of the level

    public DateTime randomdateTime { get; set; } // a DateTime variable that is used to check the date and time of the level

    [Header("GameObjects")]
    public GameObject NPC;


    [Header("Scripts")]
    [SerializeField] IDScript IdScript;
    [SerializeField] NPCSpawner Spawner;
    #endregion

    #region PassDenyNext Button

    public void Pass() // a void function that is called when the Pass is clicked
    {
        IdScript = FindFirstObjectByType<IDScript>();

        if (IdScript.passed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            Debug.Log("Passed is true");
            points++;
            text.text = "Points: " + points;
            //animator = NPC.GetComponent<Animator>();
            //animator.SetTrigger("Passed");
            Debug.Log("Animation is doorgestuurd");

        }
        else
        {
            Debug.Log("It is false");

        }
    }



    public void Deny() // a void function that is called when the Deny is clicked
    {
        IdScript = FindFirstObjectByType<IDScript>();

        if (IdScript.denied)
        {
            Debug.Log("Denied is true");

            points++;
            text.text = "Points: " + points;

            //denyAnim = true;
            animator = NPC.GetComponent<Animator>();
            animator.SetTrigger("Denied");

            Debug.Log("Animation is doorgestuurd");



        }
        else
        {
            Debug.Log("It is false");
        }
    }

    public void NextButton()
    {
        if (Spawner.npcCount == 1)
        {
            Debug.Log("Cant spawn");
        }

        if (Spawner.npcCount == 0)
        {
            Spawner.SpawnNPC();
        }
    }

    #endregion

    #region Start And Update
    void Start()
    {
        

        gameOverCanvas.gameObject.SetActive(false); // set the game over canvas to inactive at the start of the game

    }

    void Update()
    {

    }
    #endregion

    #region Main Menu Buttons
    public void Play() // a void function that is called when the StartButton is clicked
    { 
        SceneManager.LoadScene("Level1"); // load the GameScene when the StartButton is clicked
        Debug.Log("Start Button Clicked"); // print to the console that the button was clicked
    }

    public void Settings() // a void function that is called when the SettingsButton is clicked
    {
        SceneManager.LoadScene("Settings"); // load the SettingsScene when the SettingsButton is clicked
        Debug.Log("Settings Button Clicked"); // print to the console that the button was clicked
    }


    public void Quit() // a void function that is called when the QuitButton is clicked
    {
        Debug.Log("Quitting...  ..  ."); // print to the console that the button was clicked
        Application.Quit(); // quit the application
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene"); // load the MainMenuScene when the MainMenuButton is clicked
        Debug.Log("Main Menu Button Clicked"); // print to the console that the button was clicked
    }


    #endregion

}
