namespace ModAPI.Abstractions.Config
{
    public interface IItemConfig
    {
        string Id { get; }
        int TextureX { get; }
        int TextureY { get; }
        int TextureAtlas { get; }

        IItemConfig SetId(string id);
        IItemConfig SetTexture(int x, int y);
        IItemConfig SetTexture(string path);
        IItemConfig SetItemTranslation(string name);
        IItemConfig SetItemTranslation(string name, string description);
    }
}