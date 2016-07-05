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

        private IEnumerable<IExam> exams;

        public Trainer(string name, IEnumerable<IExam> exams)
            : base(name, Trainer.TrainerBaseHp)
        {
            this.exams = exams;
        }

        public IEnumerable<IExam> Exams
        {
            get
            {
                return this.exams;
            }
        }


        public TrainerType trainerType { get; protected set; }

        public void ThrowExam(IStudent st)
        {
            throw new NotImplementedException();
        }

        public void ThrowProblem(IStudent st)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Trainer Name: {this.Name}, Trainer Exams: {string.Join(Environment.NewLine, this.Exams)}";
        }
    }
}
