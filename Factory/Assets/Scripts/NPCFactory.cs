using UnityEngine;
public class NPCFactory:MonoBehaviour
{
    [SerializeField] INPC Beggar;
    [SerializeField] INPC Merchant;
    [SerializeField] INPC Knight;
    [SerializeField] INPC Farmer;
    [SerializeField] INPC Scholar;
    public INPC GetNPC (int type)
    {
        switch (type)
        {
            case 1:
                return Beggar;
            case 2:
                return Farmer;
            case 3:
                return Merchant;
            case 4:
                return Knight;
            case 5:
                return Scholar;
        }
        return null;
    }
}
