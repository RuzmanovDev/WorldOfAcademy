namespace GameObjects.Contracts
{
    using System.Collections.Generic;

    public interface IExam : IProblem
    {
        IList<IProblem> ProgblemsList { get; }
    }
}
