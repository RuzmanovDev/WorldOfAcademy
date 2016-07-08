namespace GameObjects.Models.Pets
{
    using Contracts;
    using Abstract;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Turtle : Pet, IPet
    {
        private const int KnowledgeBoost = 15;

        public Turtle(string name) : base(name)
        {
        }

        public override string HelpMe(IKnowledge knowledge)
        {
            knowledge.AddKnowledge(KnowledgeBoost);
            return $"{this.ToString()} gives the student it's wisdom!!! The student receives {Turtle.KnowledgeBoost} knowledge!";
        }
    }
}
