namespace GameObjects.Contracts
{
    public interface IStudent : IHuman
    {
        void HandleProblem(IProblem problem);
        
        IAbility ability { get; }
    }
}
