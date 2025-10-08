using StbImageSharp;

namespace ModAPI.Abstractions.Builders;

public class ItemBuilder
{
    public static ItemConfig Build(string id)
    {
        return new ItemConfig(id);
    }
}

public sealed class ItemConfig
{
    public string Id { get; private set; }
    public int TextureX { get; private set; } = 0;
    public int TextureY { get; private set; } = 0;
    public int TextureAtlas { get; private set; } = 0;
    public string? TexturePath { get; private set; }
    public Dictionary<string, (string Name, string? Description)> Translations { get; private set; } = new();

    public ItemConfig(string id)
    {
        Id = id;
    }

    public ItemConfig SetTexture(int x, int y)
    {
        TextureX = x;
        TextureY = y;
        return this;
    }
    
    public ItemConfig SetTexture(string path)
    {
        TexturePath = path;
        return this;
    }
    public ItemConfig DisplayName(string name, string locale=Locales.EN_AU)
    {
        Translations[locale] = (name, null);
        return this;
    }

    public ItemConfig Description(string description, string locale=Locales.EN_AU)
    {
        var name = Translations[locale].Name;
        Translations[locale] = (name, description);
        return this;
    }
}