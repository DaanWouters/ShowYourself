using System;
using UnityEngine;

public class LevelButton : MonoBehaviour
{


    #region Variables
    public GameObject greenButton; // Reference to the green button GameObject
    public GameObject redButton; // Reference to the red button GameObject

    #endregion




    private void OnMouseDown()
    {
        Debug.Log("Button Clicked");
    }









    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
