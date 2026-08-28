using UnityEngine;
using UnityEngine.UI; // Uses the UI system in Unity
using UnityEngine.SceneManagement; // Uses the Scene Management system in Unity
using System; // Uses the System namespace in Unity
public class ButtonScript : MonoBehaviour
{

    #region Button Variables
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
