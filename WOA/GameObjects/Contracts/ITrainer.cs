namespace GameObjects.Contracts
{
    using Enumerations;
    using System.Collections.Generic;

    public interface ITrainer : IHuman
    {
        TrainerType trainerType { get; }

        IEnumerable<IExam> Exams { get; }

        void ThrowExam(IStudent st);
    }
}
