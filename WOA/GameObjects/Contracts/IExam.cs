namespace GameObjects.Contracts
{
    using System.Collections.Generic;

    public interface IExam
    {
        IEnumerable<IProblem> ProblemList { get; }

        double Dificulty { get; }

    }
}
