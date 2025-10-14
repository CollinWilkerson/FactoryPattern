using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;
    [SerializeField] private Image NPCSprite;
    [SerializeField] private TextMeshProUGUI m_NPCText;

    private INPC activeNPC;
    
    public void NPCSpeak(int type)
    {
        activeNPC = m_Factory.GetNPC(type);
        NPCSprite.sprite = activeNPC.charSprite;
        m_NPCText.text = activeNPC.Speak();
    }
}
