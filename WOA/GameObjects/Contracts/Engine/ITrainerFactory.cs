using GameObjects.Enumerations;
using System.Collections.Generic;

namespace GameObjects.Contracts.Engine
{
    public interface ITrainerFactory
    {
        ITrainer CreateTrainer(string name, int hp, int energy, ICollection<IProblem> problems, TrainerType trinerType); // TODO: Add parameters to the constructor
    }
}
