namespace GameObjects.Models.Abstract
{
    using System;
    using GameObjects.Contracts;

    public abstract class Ability : IAbility
    {
        public virtual void DoSpecialy()
        {
            throw new NotImplementedException();
        }

        public abstract int KnowledgeBoost();
    }
}
