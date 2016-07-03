namespace GameObjects.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CommandManager
    {
        public string Command { get;  private set; }


        public void ProccessCommand(string command)
        {
            var splittedCommand = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var commandType = splittedCommand[0].ToLower();

            switch (commandType)
            {
                case "create": break;
                default: break;
            }
        }
    }
}
