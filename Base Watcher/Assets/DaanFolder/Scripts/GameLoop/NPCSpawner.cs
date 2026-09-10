using UnityEngine;

public class NPCSpawner : MonoBehaviour
{

    public Transform spawnPoint; // The point where the NPC will be spawned
    public GameObject npcPrefab; // The NPC prefab to be spawned

    public int npcCount = 0; // The number of NPCs spawned
    public int maxNPC = 1; // The maximum number of NPCs that can be spawned



    public void SpawnNPC()
    {
        if (npcCount < maxNPC)
        {
            Debug.Log("Spawning NPC..."); // Log a message when spawning an NPC
            Instantiate(npcPrefab, spawnPoint.position, spawnPoint.rotation); // Instantiate the NPC prefab at the spawn point
            npcCount++; // Increment the NPC count
        }
        else
        {

            Debug.Log("There is someone!"); // Log a message if the maximum number of NPCs is reached
        }



    }


















    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnNPC();



    }

    // Update is called once per frame
    void Update()
    {

    }
}
