namespace GameObjects.Contracts.Engine
{
    using System;

    public interface ILogger
    {
        void WriteLine(string text);

        void WriteLine(string test, ConsoleColor color);
    }
}
