namespace GameObjects.Models.Abilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Abstract;
    using Contracts;
    public class ITCompetitionChampion : Ability, IAbility
    {
        private const int KnowledgeBoostConst = 12;

        // can expolit he system e.g: commits to bg coder and get points without proper solution of the problem

        public override int KnowledgeBoost()
        {
            return KnowledgeBoostConst;
        }
    }
}
