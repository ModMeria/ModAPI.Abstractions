namespace ModAPI.Abstractions.Items.Crafting;

public class ModRecipeEntry
{
    public ModItem item;
    public int amount;

    public ModRecipeEntry(ModItem item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }
}