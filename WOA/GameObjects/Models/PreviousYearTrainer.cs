namespace GameObjects.Models
{

    using Abstract;
    using Enumerations;
    using GameObjects.Contracts;

    public class PreviousYearTrainer : Trainer, ITrainer, IHelper
    {
        private const int KnowledgeBoost = 3;

        public PreviousYearTrainer(string name)
            :base(name, TrainerType.PreviousYears)
        { }

        public string HelpMe(IKnowledge knowledge)
        {
            knowledge.AddKnowledge(KnowledgeBoost);
            return $"{base.Name} is here to help!The student receives {KnowledgeBoost} knowledge!!";
        }
    }
}
