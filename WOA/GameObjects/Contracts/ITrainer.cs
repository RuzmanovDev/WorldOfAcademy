namespace GameObjects.Contracts
{
    using Enumerations;
    using System.Collections.Generic;

    public interface ITrainer : IHuman
    {
        TrainerType trainerType { get; }

        IList<IProblem> Problems { get; }

        void ThrowProblem(IStudent st);
    }
}
