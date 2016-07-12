namespace GameObjects.Contracts
{
    public interface IHuman : ICreature
    {
        int HP { get; }

        bool IsAlive { get; }
    }
}
