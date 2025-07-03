using ModAPI.Abstractions.Config;
using ModAPI.Abstractions.Items;

namespace ModAPI.Abstractions
{
    public interface IModApi
    {
        public void RegisterItem(ItemConfig config);
        public void RegisterCraftingRecipe(CraftingRecipeConfig config);
        public void AddTranslation(string id, string translatedName);
        public void AddTranslation(string id, string translatedName, string description);
        public bool TryGetItem(string id, out ModItem item);

    }
}