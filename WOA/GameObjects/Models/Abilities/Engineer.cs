namespace GameObjects.Models.Abilities
{
    using GameObjects.Models.Abstract;
    using Contracts;

    public class Engineer : Ability, IAbility
    {
        private const int KnowledgeBoostConst = 10;
        // can solve problems easier
        public Engineer(string name)
            : base(name)
        {
        }

        public override int KnowledgeBoost()
        {
            return KnowledgeBoostConst;
        }
    }
}
