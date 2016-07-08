namespace GameObjects.Contracts
{
    using GameObjects.Enumerations;
    using GameObjects.Contracts;

    public interface IHuman : ICreature
    {
        int HP { get; }

        //int Energy { get; }
    }
}
