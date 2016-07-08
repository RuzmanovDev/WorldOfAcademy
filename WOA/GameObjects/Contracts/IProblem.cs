namespace GameObjects.Contracts
{
    using GameObjects.Enumerations;

    public interface IProblem
    {
        string Name { get; }

        double Dificulty { get; }

        ProblemType ProblemType { get; }

        void GiveKnowledge(IStudent st);
    }
}
