namespace GameObjects.Engine.Factories
{
    using System;

    using Contracts;
    using GameObjects.Contracts.Engine;
    using System.Collections.Generic;
    using Enumerations;
    using Models;
    public class TrainerFactory : ITrainerFactory
    {
        public ITrainer CreateTrainer(string name, int hp, int energy, ICollection<IProblem> problems, TrainerType trinerType)
        {
            return new Trainer(name);
        }

    }
}
