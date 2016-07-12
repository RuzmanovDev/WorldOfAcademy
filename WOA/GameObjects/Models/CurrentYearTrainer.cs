namespace GameObjects.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using GameObjects.Contracts;
    using Enumerations;
    using GameObjects.Models.Abstract;

    public class CurrentYearTrainer : Trainer, ICurrentYearTrainer, ITrainer, IHuman
    {
     
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
                if (st.IsAlive)
                {
                    resultFromTrowingExam.AppendLine(st.HandleExam(this.Exam));
                }
                else
                {
                    resultFromTrowingExam.AppendLine($"{st.Name} is too stupid for this exam");
                }
            }
            if (this.HP <= 0)
            {
                this.IsAlive = false;
            }
            return resultFromTrowingExam.ToString();
        }

        public override string ToString()
        {
            return $"Trainer Name: {this.Name}, HP {this.HP} Trainer Exams: {string.Join(Environment.NewLine, this.Exam)}";
        }
    }
}
