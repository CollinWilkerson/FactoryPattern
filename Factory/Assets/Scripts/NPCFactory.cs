public class NPCFactory
{
    public INPC GetNPC (NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                return new Beggar();
            case NPCType.Farmer:
                return new Farmer();
            case NPCType.Shopowner:
                return new Shopowner();
        }
        return null;
    }
}
