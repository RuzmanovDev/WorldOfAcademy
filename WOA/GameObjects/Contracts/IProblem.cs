namespace GameObjects.Contracts
{
    using Enumerations;

    public interface IProblem
    {
        string Name { get; }

        double Dificulty { get; }

        ProblemType ProblemType { get; }

        void GiveKnowledge(IStudent st);
    }
}