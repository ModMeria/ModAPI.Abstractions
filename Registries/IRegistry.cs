namespace ModAPI.Abstractions.Registries;

public interface IRegistry<TKey, TValue>
{
    TValue Register(TKey item);
    bool TryGet(TKey key, out TValue item);
    IReadOnlyDictionary<TKey, TValue> GetAll();
}