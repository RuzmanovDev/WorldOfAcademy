namespace GameObjects.Contracts
{
    using Enumerations;
    using System.Collections.Generic;

    public interface ITrainer : IHuman
    {
        TrainerType TrainerType { get; }
    }
}