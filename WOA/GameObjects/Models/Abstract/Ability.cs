namespace GameObjects.Models.Abstract
{
    using GameObjects.Contracts;

    public abstract class Ability : IAbility
    {
        public string Name { get; protected set; }

        public abstract int KnowledgeBoost();

    }
}
