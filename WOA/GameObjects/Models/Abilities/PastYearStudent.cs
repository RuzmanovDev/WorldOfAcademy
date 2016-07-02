namespace GameObjects.Models.Abilities
{
    using System;
    using GameObjects.Contracts;
    using Abstract;

    class PastYearStudent : Ability, IAbility
    {
        private const int KnowledgeBoostConst = 20;

        public override int KnowledgeBoost()
        {
            return KnowledgeBoostConst;
        }
    }
    // can summon trainers from past years to help him
}

