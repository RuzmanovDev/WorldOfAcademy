using GameObjects.Contracts;
using GameObjects.Enumerations;

namespace GameObjects.Contracts
{
    public interface IStudent : IHuman
    {
        void HandleProblem(IProblem problem);

        IKnowledge Knowledge { get; }

        StudentType StudentType { get; }

        OtherCompetence OtherCompetence { get; }

        void ReceiveKnowledge(double knowledge);

        IPet Pet { get; }
    }
}
