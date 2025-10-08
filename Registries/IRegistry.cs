namespace ModAPI.Abstractions.Registries;

public interface IRegistry<T>
{
    T Register(string id, T item);
    bool TryGet(string id, out T item);
    IReadOnlyDictionary<string, T> GetAll();
    // Hack because IRegistry<T>
    IReadOnlyDictionary<string, string> GetAll(string locale);
}