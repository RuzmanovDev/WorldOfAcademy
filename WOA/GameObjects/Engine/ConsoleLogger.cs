﻿namespace GameObjects.Engine
{
    using System;

    using Contracts.Engine;
 
    public class ConsoleLogger : ILogger
    {
        public void WriteLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
        }

        public void LogError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
        }
    }
}
