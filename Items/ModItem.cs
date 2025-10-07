using ModAPI.Abstractions.Config;

namespace ModAPI.Abstractions.Items
{
    public class ModItem
    {
        public int id;
        public ItemConfig config;

        public ModItem(int id, ItemConfig config)
        {
            this.id = id;
            this.config = config;
        }
    }
}

