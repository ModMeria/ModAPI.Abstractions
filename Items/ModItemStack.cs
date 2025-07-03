namespace ModAPI.Abstractions.Items;

public class ModItemStack
{
    private ModItem modItem;
    public int amount;
    
    public ModItem GetItem() => modItem;

    public ModItemStack(ModItem modItem, int amount)
    {
        this.modItem = modItem;
        this.amount = amount;
    }
}