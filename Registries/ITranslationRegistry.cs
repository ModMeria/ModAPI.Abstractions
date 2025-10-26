
namespace ModAPI.Abstractions.Registries
{
    public interface ITranslationRegistry : IRegistry<string, string>
    {
        string Register(string locale, string id, string item);

        bool TryGet(string locale, string key, out string value);
        // Hack because IRegistry<T>
        IReadOnlyDictionary<string, string> GetAll(string locale);
    }
}
