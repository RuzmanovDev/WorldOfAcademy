namespace GameObjects.Contracts
{
    using Enumerations;
    using System.Collections.Generic;

    public interface ITrainer : IHuman
    {
        TrainerType trainerType { get; }

        ICollection<IProblem> Problems { get; }

        void ThrowProblem(IStudent st);
    }
}
