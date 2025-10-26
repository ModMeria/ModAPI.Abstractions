using ModAPI.Abstractions.Textures;

namespace ModAPI.Abstractions.Registries;

public interface ITextureRegistry : IRegistry<string, ModTexture>
{
}