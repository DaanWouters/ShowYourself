using UnityEngine;

public class DestroyID : MonoBehaviour
{

    public bool destroyID = true; // Boolean to check if the ID card should be destroyed
    public GameObject idCard; // GameObject for ID card for dropping it

    [SerializeField] private DropIDSystem dropIDSystem; // Reference to the DropIDSystem script

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

}
