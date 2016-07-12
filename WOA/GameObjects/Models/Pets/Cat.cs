namespace GameObjects.Models.Pets
{
    using Abstract;
    using Contracts;

    public class Cat : Pet, IPet
    {
        private const int KnowledgeBoost = -5;

        public Cat(string name) : base(name)
        {
        }

        public override string HelpMe(IKnowledge knowledge)
        {
            knowledge.AddKnowledge(KnowledgeBoost);
            return $"{this.ToString()} ate the homework!! The student receives {Cat.KnowledgeBoost} knowledge!!";
        }

    }
}
