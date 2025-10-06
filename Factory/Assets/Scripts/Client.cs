using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    private void Start()
    {
        m_SpawnerNPC = gameObject.AddComponent<NPCSpawner>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
    }
}
