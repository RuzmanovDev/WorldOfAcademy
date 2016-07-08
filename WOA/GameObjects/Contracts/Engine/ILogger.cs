namespace GameObjects.Contracts.Engine
{
    public interface ILogger
    {
        void WriteLine(string text);

        void LogError(string test);
    }
}
