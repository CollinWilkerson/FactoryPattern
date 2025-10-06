using UnityEngine;

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner
}

public interface INPC
{
    public void Speak();
}
