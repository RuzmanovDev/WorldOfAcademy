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

    // public delegate void ExamStartEventHandler(object sender, IStudent st);

    public class CurrentYearTrainer : Trainer, ICurrentYearTrainer, ITrainer, IHuman
    {
        //TODO add the event to the Itrainer
        //  public event ExamStartEventHandler ExamStart; 

        

        private IExam exam;

        public CurrentYearTrainer(string name, IExam exam)
            : base(name, TrainerType.CurrentYear)
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




        public string ThrowExam(IEnumerable<IStudent> studentList)
        {
            this.HP -= (int)this.Exam.Dificulty;

            var resultFromTrowingExam = new StringBuilder();

            foreach (var st in studentList)
            {
                resultFromTrowingExam.AppendLine(st.HandleExam(this.Exam));
            }

            return resultFromTrowingExam.ToString();
        }


        //public virtual void OnExamStart(IStudent st)
        //{
        //    if (ExamStart != null)
        //        ExamStart(this, st);
        //}

        public override string ToString()
        {
            return $"Trainer Name: {this.Name}, HP {this.HP} Trainer Exams: {string.Join(Environment.NewLine, this.Exam)}";
        }
    }
}
