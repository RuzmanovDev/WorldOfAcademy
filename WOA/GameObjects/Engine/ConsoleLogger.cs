namespace GameObjects.Engine
{
    using System;

    using Contracts.Engine;
    /// <summary>
    /// should use it instead of pure console.writeline
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        public void WriteLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
        }
    }
}
