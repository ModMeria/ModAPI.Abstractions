using System.Numerics;
using ModAPI.Abstractions.Config;
using ModAPI.Abstractions.Items;
using StbImageSharp;

namespace ModAPI.Abstractions
{
    public interface IModApi
    {
        public void RegisterItem(IItemConfig config);
        public void RegisterCraftingRecipe(CraftingRecipeConfig config);
        public void AddTranslation(string id, string translatedName);
        public void AddTranslation(string id, string translatedName, string description);
        public bool TryGetItem(string id, out ModItem item);
        public Vector3 RegisterTexture(ImageResult imageResult);

    }
}