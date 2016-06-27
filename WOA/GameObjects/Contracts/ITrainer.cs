namespace GameObjects.Contracts
{
    using System.Collections.Generic;

    public interface ITrainer : IHuman
    {
        IList<IProblem> Problems { get; }

        void ThrowProblem(IStudent st);
    }
}
