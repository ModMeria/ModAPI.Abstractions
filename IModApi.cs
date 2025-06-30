using ModAPI.Abstractions.Config;

namespace ModAPI.Abstractions
{
    public interface IModApi
    {
        public void RegisterItem(IItemConfig config);
        public void RegisterCraftingRecipe(ICraftingRecipeConfig config);
        public void AddTranslation(string id, string translatedName);
        public void AddTranslation(string id, string translatedName, string description);
    }
}