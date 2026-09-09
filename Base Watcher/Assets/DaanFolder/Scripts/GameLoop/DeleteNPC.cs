using UnityEngine;

public class DeleteNPC : MonoBehaviour
{


    public GameObject NPC;
    [SerializeField] private NPCSpawner spawner;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Destroy(collision.gameObject);
            spawner.npcCount = 0;
        }
        else
        {
            Debug.Log("No NPC detected");
        }

    }




}
