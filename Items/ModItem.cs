using ModAPI.Abstractions.Builders;

namespace ModAPI.Abstractions.Items
{
    public class ModItem
    {
        public string id;
        public ItemConfig config;

        public ModItem(string id, ItemConfig config)
        {
            this.id = id;
            this.config = config;
        }
    }
}

