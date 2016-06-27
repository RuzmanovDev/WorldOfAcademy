namespace GameObjects.Contracts
{
    public interface IProblem
    {
        string Name { get; }

        int Dificulty { get; }

        void GiveKnowledge(IStudent st);
    }
}
