using PocketBlocks.Items;
using PocketBlocks.Items.Crafting;

namespace ModAPI.Abstractions.Config
{
    public interface ICraftingRecipeConfig
    {
        ItemStack? Result { get; }
        CraftingStation CraftingStation { get; }
        List<RecipeEntry> Recipe { get; }

        ICraftingRecipeConfig SetResult(Item item, int amount);
        ICraftingRecipeConfig SetResult(ItemStack item);
        ICraftingRecipeConfig SetResult(string itemId, int amount);

        ICraftingRecipeConfig SetCraftingStation(CraftingStation craftingStation);
        ICraftingRecipeConfig AddRecipeEntry(RecipeEntry recipe);
        ICraftingRecipeConfig AddRecipeEntry(Item item, int amount);
        ICraftingRecipeConfig AddRecipeEntry(string itemId, int amount);
    }
}