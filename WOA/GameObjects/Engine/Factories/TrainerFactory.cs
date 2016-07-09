namespace GameObjects.Engine.Factories
{
    using System;
    using Contracts;
    using GameObjects.Contracts.Engine;
    using Models;
    using Common;

    public class TrainerFactory : ITrainerFactory
    {
        private string[] trainerNames = { "Ivo Kenov", "Niki Kostov"};

        public ITrainer CreateCurrentYearTrainer(string name, IExam exam)
        {
            return new CurrentYearTrainer(name, exam);
        }

        public ITrainer CreatePreviousTrainer()
        {
            return new PreviousYearTrainer(this.GenerateTrainerName());
        }

        private string GenerateTrainerName()
        {
            return trainerNames[RandomProvider.Instance.Next(trainerNames.Length)];
        }
    }
}
