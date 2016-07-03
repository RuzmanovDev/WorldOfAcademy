namespace GameObjects.Engine
{
    using System;
    using GameObjects.Contracts.Engine;
    using Factories;

    public class GameObjectManufacturerEngine : IGameObjectManufacturerEngine
    {
        public void Start()
        {
            IStudentFactory studentFactory = GetStudentFactory();
            ITrainerFactory trainerFactory = GetTrainerFactory();
            IAblityFactory abilityFactory = GetAbilityFactory();
        }

        private IStudentFactory GetStudentFactory()
        {
            return new StudentFactory();
        }

        private ITrainerFactory GetTrainerFactory()
        {
            return new TrainerFactory();
        }

        private IAblityFactory GetAbilityFactory()
        {
            return new AbilityFactory();
        }
    }
}
