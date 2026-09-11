using UnityEngine;

public class DestroyScript : MonoBehaviour
{

    #region Variables
    [Header("Bools")]
    public bool destroyID; // Boolean to check if the ID card should be destroyed
    
    [Header("GameObjects")]
    public GameObject idCard; // GameObject for ID card for dropping it

    [Header("Scripts")]
    [SerializeField] private DropIDSystem dropIDSystem; // Reference to the DropIDSystem script
    #endregion

    #region OnCollision ID
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ID")) 
        {
            Destroy(collision.gameObject); // Destroy the ID card object
            dropIDSystem.idCount = 0; // Reset the idCount to 0 to allow for a new ID card to be generated
        }
        else
        {
            Debug.Log("Cant Find ID Card");   
        }
    }
    #endregion

}
