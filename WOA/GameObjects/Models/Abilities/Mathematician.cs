namespace GameObjects.Models.Abilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Abstract;

    public class Mathematician : Ability
    {
        private const int KnowledgeBoostConst = 20;

        // can solve problems faster
        public Mathematician(string name) : base(name)
        {
        }

        public override int KnowledgeBoost()
        {
            return KnowledgeBoostConst;
        }
    }
}
