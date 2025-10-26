using ModAPI.Abstractions.Builders;
using ModAPI.Abstractions.Items;

namespace ModAPI.Abstractions.Registries;

public interface IItemRegistry : IRegistry<ItemConfig, ModItem>
{
    public bool TryGet(string id, out ModItem item);
}