using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DropIDSystem : MonoBehaviour
{



    //Region for organisation
    #region Variables

    public Rigidbody2D rb; // Reference to the Rigidbody2D component
    public BoxCollider2D boxCollider; // Reference to the BoxCollider2D component
    public GameObject NPC; // Reference to the NPC GameObject
    public GameObject idCard; // GameObject for ID card for dropping it



    int idCount = 1; // Counter for generating unique IDs
    int paperCount = 1; // Counter for the number of papers dropped








    #endregion





    #region Collisions
    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("Collision");


        if (col.gameObject.CompareTag("Dropper"))
        {
            Debug.Log("Collision");
        }
    }

    #endregion





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        
    }
}
