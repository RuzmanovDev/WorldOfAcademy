namespace GameObjects.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CommandManager
    {

        public string Command { get; private set; }


        public CommandManager(InteractionManager interactionManager)
        {
            this.InteractionManager = interactionManager;
        }

        public InteractionManager InteractionManager { get; private set; }

        public void ProccessCommand(string command)
        {
            var splittedCommand = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var commandType = splittedCommand[0].ToLower();

            switch (commandType)
            {
                case "create":
                    this.ExecuteCreateCommand(splittedCommand[1], splittedCommand[2]);
                    break;
                default: break;
            }
        }

        private void ExecuteCreateCommand(string obejctType, string objectName)
        {
          //  this.InteractionManager.
        }
    }
}
