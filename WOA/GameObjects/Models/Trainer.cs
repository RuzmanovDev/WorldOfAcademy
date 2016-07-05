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
        private const int TrainerBaseHp = 100;

        private ICollection<IProblem> problems;

        public Trainer(string name)
            : base(name, Trainer.TrainerBaseHp)
        {
        }

        public ICollection<IProblem> Problems
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
