﻿namespace GameObjects.Engine.Factories
{
    using System;

    using Contracts;
    using GameObjects.Contracts.Engine;
    using System.Collections.Generic;
    using Enumerations;
    using Models;
    public class TrainerFactory : ITrainerFactory
    {
        public ITrainer CreateTrainer(string name, IEnumerable<IExam> exams)
        {
            return new Trainer(name, exams);
        }

    }
}
