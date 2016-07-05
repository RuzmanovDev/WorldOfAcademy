using GameObjects.Enumerations;

namespace GameObjects.Contracts
{
    public interface IStudent : IHuman
    {
        void HandleProblem(IProblem problem);

        int Knowledge { get; }

        StudentType StudentType { get; }

        void ReceiveKnowledge(int knowledge);
    }
}
