namespace GameObjects.Models
{

    using GameObjects.Contracts;
    using Enumerations;
    using Abstract;
    using System;

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
