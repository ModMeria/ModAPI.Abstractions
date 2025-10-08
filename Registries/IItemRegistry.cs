using ModAPI.Abstractions.Builders;
using ModAPI.Abstractions.Items;

namespace ModAPI.Abstractions.Registries;

// Doesn't implement IRegistry because it returns ModItem not ItemConfig
public interface IItemRegistry
{
    ModItem Register(ItemConfig config);
    IReadOnlyDictionary<string, ModItem> GetAll();
    bool TryGet(string id, out ModItem item);
}