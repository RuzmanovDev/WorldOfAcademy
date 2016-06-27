namespace GameObjects.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameObjects.Contracts;
    using Enumerations;
    using GameObjects.Models.Abstract;

    public class Trainer : Human, ITrainer, IHuman
    {
        private IList<IProblem> problems;

        public Trainer(string name, int hp, int energy, IList<IProblem> problems, TrainerType trinerType)
            : base(name, hp, energy)
        {
            this.Problems = problems;
            this.trainerType = trinerType;
        }

        public IList<IProblem> Problems
        {
            get
            {
                return this.problems;
            }

            private set
            {
                this.problems = value;
            }
        }

        public TrainerType trainerType { get; protected set; }

        public void ThrowProblem(IStudent st)
        {
            throw new NotImplementedException();
        }
    }
}
