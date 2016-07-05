using GameObjects.Enumerations;
using System.Collections.Generic;

namespace GameObjects.Contracts.Engine
{
    public interface ITrainerFactory
    {
        ITrainer CreateTrainer(string name, IEnumerable<IExam> problems); // TODO: Add parameters to the constructor
    }
}
