using GameObjects.Enumerations;

namespace GameObjects.Contracts
{
    public interface IStudent : IHuman
    {
        void HandleProblem(IProblem problem);

        int Knowledge { get; }

        StudentType StudentType { get; }

        OtherCompetence OtherCompetence { get; }

        void ReceiveKnowledge(int knowledge);

    }
}
