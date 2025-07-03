namespace ModAPI.Abstractions.Config
{
    public class ItemConfig
    {
        private readonly IModApi _api;
        public string? Id { get; private set; }
        public int TextureX { get; private set; } = 0;
        public int TextureY { get; private set; } = 0;

        public ItemConfig(IModApi api)
        {
            _api = api;
        }

        public ItemConfig SetId(string id)
        {
            this.Id = id;
            return this;
        }

        public ItemConfig SetTexture(int x, int y)
        {
            this.TextureX = x;
            this.TextureY = y;
            return this;
        }

        public ItemConfig SetItemTranslation(string name)
        {
            if (this.Id != null)
            {
                _api.AddTranslation($"item.{this.Id}", name);
            }
            else
            {
                Console.WriteLine("[ModMeria] WARN: Tried to add translation to item with no ID.");
            }

            return this;
        }

        public ItemConfig SetItemTranslation(string name, string description)
        {
            if (this.Id != null)
            {
                _api.AddTranslation($"item.{this.Id}", name, description);
            }
            else
            {
                Console.WriteLine("[ModMeria] WARN: Tried to add translation to item with no ID.");
            }

            return this;
        }
    }
}