using ModAPI.Abstractions.Builders;
using ModAPI.Abstractions.Logging;
using ModAPI.Abstractions.Registries;

namespace ModAPI.Abstractions
{
    public interface IModApi
    {
        // Registries
        IItemRegistry Items { get; }
        ITranslationRegistry Translations { get; }

        // Factories
        ILoggerFactory LoggerFactory { get; }

        // Builders
        ItemBuilder ItemBuilder { get; }
    }
}