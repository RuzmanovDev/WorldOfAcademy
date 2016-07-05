namespace GameObjects.Contracts.Engine
{
    using System;

    public interface ILogger
    {
        void WriteLine(string text);

        void LogError(string test);
    }
}
