namespace GameObjects.Contracts
{
    using Enumerations;
    using System.Collections.Generic;

    public interface ITrainer : IHuman
    {
        TrainerType trainerType { get; }

        IExam Exam { get; }

        string ThrowExam(IEnumerable<IStudent> st);
    }
}