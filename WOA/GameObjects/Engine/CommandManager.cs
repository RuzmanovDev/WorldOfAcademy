namespace GameObjects.Engine
{
    using Contracts.Engine;
    using Enumerations;
    using System;

    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // parse the commands and pass them to the interaction manager
    public class CommandManager
    {
        public CommandManager(IInteractionManager interactionManager)
        {
            this.InteractionManager = interactionManager;
        }

        public string Command { get; private set; }

        public IInteractionManager InteractionManager { get; private set; }

        public void ProccessCommand(string command)
        {
            var splittedCommand = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var commandType = splittedCommand[0].ToLower();

            switch (commandType)
            {
                case "create":
                    this.ParseCreateCommand(splittedCommand[1], splittedCommand[2]);
                    break;
                case "exam":
                    this.ExecuteExamCommand();
                    break;
                case "status":
                    this.ParseStatusCommand(splittedCommand[1]);
                    break;
                default: break;
            }
        }

        private void ParseStatusCommand(string name)
        {
            this.InteractionManager.PrintStatus(name);
        }

        private void ParseCreateCommand(string objectType, string objectName)
        {
            switch (objectType.ToLower())
            {
                case "trainer":
                    this.InteractionManager.AddTrainer(objectName,TrainerType.Current);
                    break;
                case "student":
                    this.InteractionManager.AddStudent(objectName);
                    break;
            }

         
        }

        private void ExecuteExamCommand()
        {
            // TODO: 
        }
    }
}
