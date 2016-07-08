namespace GameObjects.Models.Pets
{
    using Contracts;
    using Abstract;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GoldFish : Pet, IPet
    {
        private const int KnowledgeBoost = 10;

        public GoldFish(string name) : base(name)
        {
        }

        public override string HelpMe(IKnowledge knowledge)
        {
            knowledge.AddKnowledge(KnowledgeBoost);
            return $"{this.ToString()} blessed the student! The student receives {GoldFish.KnowledgeBoost} knowledge!"; 
        }
    }
}
