using ModAPI.Abstractions.Config;

namespace ModAPI.Abstractions.Items
{
    public class ModItem
    {
        public int id;
        public IItemConfig config;

        public ModItem(int id, IItemConfig config)
        {
            this.id = id;
            this.config = config;
        }
    }
}

