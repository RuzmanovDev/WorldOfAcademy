namespace GameObjects.Contracts
{
    using System.Collections.Generic;

    interface ICurrentYearTrainer : ITrainer
    {
        IExam Exam { get; }

        string ThrowExam(IEnumerable<IStudent> st);
    }
}
