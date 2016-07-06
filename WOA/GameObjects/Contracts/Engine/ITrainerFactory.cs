using GameObjects.Enumerations;
using System.Collections.Generic;

namespace GameObjects.Contracts.Engine
{
    public interface ITrainerFactory
    {
        ITrainer CreateTrainer(string name, IExam exam); // TODO: Add parameters to the constructor
    }
}
