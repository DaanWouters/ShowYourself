using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene"); // load the MainMenuScene when the MainMenuButton is clicked
        Debug.Log("Main Menu Button Clicked"); // print to the console that the button was clicked
        Time.timeScale = 1f;
    }



}
