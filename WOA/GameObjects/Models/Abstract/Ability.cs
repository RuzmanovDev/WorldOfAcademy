namespace GameObjects.Models.Abstract
{
    using GameObjects.Contracts;

    public abstract class Ability : IAbility
    {
        public Ability(string name)
        {
            this.Name = name;
        }
        public string Name { get; protected set; }

        public abstract int KnowledgeBoost();

    }
}
