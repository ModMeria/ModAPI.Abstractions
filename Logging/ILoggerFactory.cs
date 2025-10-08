namespace ModAPI.Abstractions.Logging
{
    public interface ILoggerFactory
    {
        ILogger GetLogger(string modId);
    }
}
