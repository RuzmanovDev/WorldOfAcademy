namespace Console_Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameObjects.Contracts.Engine;
    using GameObjects.Engine.Factories;
    using GameObjects.Engine;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();

            IInteractionManager interactionManager = new InteractionManager(logger);

            var commandManager = new CommandManager(interactionManager);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                string command = Console.ReadLine();

                commandManager.ProccessCommand(command);

                if (command == "end")
                {
                    return;
                }
            }
        }
    }
}
