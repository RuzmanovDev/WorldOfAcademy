namespace GameObjects.Contracts
{
    using System.Collections.Generic;

    public interface IExam : IProblem
    {
        ICollection<IProblem> ProgblemsList { get; }
    }
}
