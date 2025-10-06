using UnityEngine;
using TMPro;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;
    [SerializeField] private TextMeshProUGUI m_NPCName;
    [SerializeField] private TextMeshProUGUI m_NPCText;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;

    private void Start()
    {
        m_Factory = new NPCFactory();
        SpawnVillagers();
    }

    private void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar); 
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);        
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
    }

    public void BeggarSpeak()
    {
        m_NPCName.text = "Beggar";
        m_NPCText.text = m_Beggar.Speak();
    }

    public void FarmerSpeak()
    {
        m_NPCName.text = "Farmer";
        m_NPCText.text = m_Farmer.Speak();
    }
    public void ShopkeeperSpeak()
    {
        m_NPCName.text = "Shop Keeper";
        m_NPCText.text = m_Shopowner.Speak();
    }
}
