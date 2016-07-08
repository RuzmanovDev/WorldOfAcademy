namespace GameObjects.Contracts
{
    using System.Collections.Generic;

    public interface IExam
    {
        IEnumerable<IProblem> ProblemList { get; }

        void RestoreHP(IStudent student);

        double Dificulty { get; }
    }
}
