namespace GameObjects.Models.Abilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Abstract;
    using Contracts;
    public class Mathematician : Ability, IAbility
    {
        private const int KnowledgeBoostConst = 20;

        // can solve problems faster
       

        public override int KnowledgeBoost()
        {
            return KnowledgeBoostConst;
        }
    }
}
