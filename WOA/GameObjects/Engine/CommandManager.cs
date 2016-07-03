namespace GameObjects.Engine
{
    using Enumerations;
    using System;

    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    // parse the commands and pass them to the interaction manager
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
                case "exam":
                    this.ExecuteExamCommand();
                    break;
                default: break;
            }
        }

        private void ExecuteCreateCommand(string objectType, string objectName)
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
