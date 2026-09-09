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
    public GameObject spawnPoint; // GameObject for the spawn point of the ID card

    public int idCount; // Boolean to check if an ID has been generated
    public int maxCount = 2; // Maximum number of IDs that can be generated


    public bool paperCount; // Boolean to check if a paper has been dropped
    public bool extraPapers; // Boolean to check if the maximum number of papers has been dropped

    #endregion


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        idCount = 0; // Initialize idCount to 0
        paperCount = false; // Initialize paperCount to false
        extraPapers = false; //Initialize extraPapers to false
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NPC") && idCount < maxCount)
        {
            Debug.Log("Unique ID generated: " + GenerateUniqueID()); // Generate a unique ID and print it to the console
            Instantiate(idCard, spawnPoint.transform.position, spawnPoint.transform.rotation); // Instantiate the ID card at the spawn point
            idCount = 1; // Set the idCount to true to indicate that an ID has been generated
        }
       
        
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
