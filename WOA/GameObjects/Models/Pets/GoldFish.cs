namespace GameObjects.Models.Pets
{
    using Abstract;
    using Contracts;

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
