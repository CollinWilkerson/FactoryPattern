using UnityEngine;

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner,
    knight,
    scholar
}

[CreateAssetMenu (fileName = "NewNPC", menuName = "NPC", order = 1)]
public class INPC: ScriptableObject
{
    [Tooltip("Flavor text for the charater to say")]
    [SerializeField] private string line;
    [Tooltip("The sprite for the character")]
    public Sprite charSprite;

    public string Speak()
    {
        return line;
    }
}
