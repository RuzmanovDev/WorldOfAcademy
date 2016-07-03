namespace Console_Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameObjects.Contracts.Engine;
    using GameObjects.Engine.Factories;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            IStudentFactory studentFactory = GetStudentFactory();
            ITrainerFactory trainerFactory = GetTrainerFactory();
            IAblityFactory abilityFactory = GetAbilityFactory();


        }

        private static IStudentFactory GetStudentFactory()
        {
            return new StudentFactory();
        }

        private static ITrainerFactory GetTrainerFactory()
        {
            return new TrainerFactory();
        }

        private static IAblityFactory GetAbilityFactory()
        {
            return new AbilityFactory();
        }
    }
}
