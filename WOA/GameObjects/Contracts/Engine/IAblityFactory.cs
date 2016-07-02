namespace GameObjects.Contracts.Engine
{
    public interface IAblityFactory
    {
        IAbility CreateAbility(string name); // TODO: add parameters to the constructor
    }
}
