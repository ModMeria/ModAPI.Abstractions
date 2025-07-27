namespace ModAPI.Abstractions.Registry;

public interface IRegistry<T>
{
    void Register(string id, T item);
    bool TryGet(string id, out T item);
    IReadOnlyDictionary<string, T> GetAll();
}