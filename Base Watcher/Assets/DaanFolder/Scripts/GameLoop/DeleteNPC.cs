using UnityEngine;

public class DeleteNPC : MonoBehaviour
{

    #region Variables
    [Header("GameObjects")]
    public GameObject NPC;

    [Header("Scripts")]
    [SerializeField] private NPCSpawner spawner;
    #endregion

    #region OnCollisionEnter NPC
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
    #endregion

}
