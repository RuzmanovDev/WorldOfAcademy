namespace GameObjects.Models.Stats
{
    using System;
    using GameObjects.Contracts;

    public class KnowledgeStats : IKnowledge
    {
        private double knowledge;

        public KnowledgeStats(double knowledge)
        {
            this.Knowledge = knowledge;
        }

        public double Knowledge
        {
            get
            {
                return this.knowledge;
            }

            private set
            {
                this.knowledge = value;
            }
        }

        public void AddKnowledge(double knowledge)
        {
            this.Knowledge += knowledge;
        }
    }
}
