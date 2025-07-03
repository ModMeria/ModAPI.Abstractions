namespace ModAPI.Abstractions.Registry;

public interface IRegistry<T>
{
    bool Register(string id, T item);
    bool TryGet(string id, out T item);
    IReadOnlyDictionary<string, T> GetAll();
}