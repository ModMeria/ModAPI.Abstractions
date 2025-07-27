using ModAPI.Abstractions;
using StbImageSharp;

namespace ModAPI.Core.Config;

public class ItemConfig
{
    private readonly IModApi _api;
    public string Id { get; private set; }
    public int TextureX { get; private set; }
    public int TextureY { get; private set; }
    public int TextureAtlas { get; private set; }

    public ItemConfig(IModApi api, string id)
    {
        _api = api;
        Id = id;
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
    
    public ItemConfig SetTexture(string path)
    {
        using var stream = File.OpenRead(path);
        var image = ImageResult.FromStream(stream, ColorComponents.RedGreenBlueAlpha);

        var pos = _api.RegisterTexture(image);
        return this;
    }

    public ItemConfig SetItemTranslation(string name)
    {
        _api.AddTranslation($"item.{this.Id}", name);
        return this;
    }

    public ItemConfig SetItemTranslation(string name, string description)
    {
        _api.AddTranslation($"item.{this.Id}", name, description);
        return this;
    }
}