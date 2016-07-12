namespace GameObjects.Contracts
{
    public interface IKnowledge
    {
        double Knowledge { get; }

        void AddKnowledge(double knowledge);
    }
}