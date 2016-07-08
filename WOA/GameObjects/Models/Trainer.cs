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

    public delegate void ExamStartEventHandler(object sender, IStudent st);

    public class Trainer : Human, ITrainer, IHuman
    {
        //TODO add the event to the Itrainer
        public event ExamStartEventHandler ExamStart; 

        private const int TrainerBaseHp = 100;

        private IExam exam;

        public Trainer(string name, IExam exam)
            : base(name, Trainer.TrainerBaseHp)
        {
            this.exam = exam;
        }

        public IExam Exam
        {
            get
            {
                return this.exam;
            }
        }


        public TrainerType trainerType { get; protected set; }

        public void ThrowExam(IEnumerable<IStudent> studentList)
        {
            foreach (var st in studentList)
            {
                // TODO is this working
                OnExamStart(st);
               // string str = st.Pet.HelpMe(st);
                foreach (var pr in this.Exam.ProblemList)
                {
                    st.HandleProblem(pr);
                }
            }
        }


        public virtual void OnExamStart(IStudent st)
        {
            if (ExamStart != null)
                ExamStart(this, st);
        }
        public override string ToString()
        {
            return $"Trainer Name: {this.Name}, Trainer Exams: {string.Join(Environment.NewLine, this.Exam)}";
        }
    }
}
