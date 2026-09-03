using NUnit.Framework;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerator : MonoBehaviour
{
    #region Variables
    string[] names = { "Alice", "Bob", "Charlie", "David", "Eve", "Fay", "Grace", "Hank", "Ivy", "Jack", "Kara", "Liam"};
    string[] Ages = { "18", "25", "57", "60" };

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Age;
    public TextMeshProUGUI ExpireDate;
    #endregion


    #region Randomizer
    internal string NameRandomizer()
    {
        int randomIndex = UnityEngine.Random.Range(0, names.Length);
        return names[randomIndex];
    }


    internal string AgeRandomizer()
    {
        int randomIndex = UnityEngine.Random.Range(0, Ages.Length);
        return Ages[randomIndex];
    }


   



    #endregion


    #region Start void
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       // Debug.Log("Random name generated: " + NameRandomizer() + " Included with Age: " + AgeRandomizer() + " And Expire Date: " + ExpireDateRandomizer());
    }
    #endregion


    #region Update void
    // Update is called once per frame
    void Update()
    {

    }
    #endregion

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dropper"))
        {
            Name.text = "Name: " + NameRandomizer();
            Age.text = "Age: " + AgeRandomizer();
            Debug.Log("Name: " + NameRandomizer() + " Age: " + AgeRandomizer());
        }
        else
        {
            Debug.Log("No NPC detected");
        }


    }
}