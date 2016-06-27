namespace GameObjects.Contracts
{
    public interface IHuman
    {
        string Name { get; }

        int HP { get; }

        int Energy { get; }
    }
}
