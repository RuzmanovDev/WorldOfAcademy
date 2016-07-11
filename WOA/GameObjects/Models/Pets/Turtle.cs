namespace GameObjects.Models.Pets
{
    using Abstract;
    using Contracts;

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
