using GameObjects.Enumerations;

namespace GameObjects.Contracts
{
    public interface IStudent : IHuman
    {
        void HandleProblem(IProblem problem);

        int Knowledge { get; }

        StudentTye StudentType { get; }
    }
}
