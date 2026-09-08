using UnityEngine;

public class DeleteNPC : MonoBehaviour
{


    public GameObject NPC;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Destroy(NPC);
            Debug.Log("NPC Deleted");
        }
        else
        {
            Debug.Log("No NPC detected");
        }
    }




}
