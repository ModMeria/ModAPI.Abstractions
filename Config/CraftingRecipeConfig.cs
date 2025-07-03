using ModAPI.Abstractions.Items;
using ModAPI.Abstractions.Items.Crafting;

namespace ModAPI.Abstractions.Config
{
    public class CraftingRecipeConfig
    {
        public ModItemStack? Result { get; private set; }
        public ModCraftingStation CraftingStation { get; private set; } = new ModCraftingStation("work_bench");
        public List<ModRecipeEntry> Recipe { get; set; } = new List<ModRecipeEntry>();
        private readonly IModApi _api;

        public CraftingRecipeConfig(IModApi api)
        {
            _api = api;
        }

        public CraftingRecipeConfig SetResult(ModItem item, int amount)
        {
            this.Result = new ModItemStack(item, amount);
            return this;
        }

        public CraftingRecipeConfig SetResult(ModItemStack item)
        {
            this.Result = item;
            return this;
        }

        public CraftingRecipeConfig SetResult(string itemId, int amount)
        {
            if (_api.TryGetItem(itemId, out var item))
            {
                SetResult(item, amount);
            }
            else
            {
                Console.WriteLine("[ModMeria] Tried to add a result for an item with nonexistent id. HINT: If you're trying to add a Result for a built-in Item don't use string IDs.");
            }
            return this;
        }

        public CraftingRecipeConfig SetCraftingStation(ModCraftingStation craftingStation)
        {
            this.CraftingStation = craftingStation;
            return this;
        }

        public CraftingRecipeConfig AddRecipeEntry(ModRecipeEntry recipe)
        {
            this.Recipe.Add(recipe);
            return this;
        }

        public CraftingRecipeConfig AddRecipeEntry(ModItem item, int amount)
        {
            this.Recipe.Add(new ModRecipeEntry(item, amount));
            return this;
        }

        public CraftingRecipeConfig AddRecipeEntry(string itemId, int amount)
        {
            if (_api.TryGetItem(itemId, out var item))
            {
                AddRecipeEntry(item, amount);
            }
            else
            {
                Console.WriteLine("[ModMeria] Tried to add a crafting recipe for an item with nonexistent id. HINT: If you're trying to add a RecipeEntry for a built-in Item don't use string IDs.");
            }
            return this;
        }
    }
}
