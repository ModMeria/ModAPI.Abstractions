
namespace ModAPI.Abstractions.Registries
{
    public interface ITranslationRegistry : IRegistry<string>
    {
        string Register(string locale, string id, string item);

        bool TryGet(string locale, string key, out string value);
    }
}
