using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DropIDSystem : MonoBehaviour
{



    //Region for organisation
    #region Variables

    public Rigidbody2D rb; // Reference to the Rigidbody2D component
    public BoxCollider2D boxCollider; // Reference to the BoxCollider2D component
    public GameObject idCard; // GameObject for ID card for dropping it


    public bool idCount; // Boolean to check if an ID has been generated
    public bool paperCount; // Boolean to check if a paper has been dropped
    public bool extraPapers; // Boolean to check if the maximum number of papers has been dropped

    #endregion


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        idCount = false; // Initialize idCount to false
        paperCount = false; // Initialize paperCount to false
        extraPapers = false; //Initialize extraPapers to false
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dropper"))
        {
            Debug.Log("Unique ID generated: " + GenerateUniqueID()); // Generate a unique ID and print it to the console
        }
        idCount = true; // Set the idCount to true to indicate that an ID has been generated
        paperCount = true; // Set the paperCount to true to indicate that a paper has been dropped
        extraPapers = true; // Set the extraPapers to true to indicate that the maximum number of papers has been dropped
    } 

    


    int GenerateUniqueID()
    {
        int uniqueID = Random.Range(1000000, 0001); 
        return uniqueID;
    }


    // Update is called once per frame
    void Update()
    {


    }
}
