namespace GameObjects.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;

    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Enumerations;

    public class Exam : IExam
    {
        private readonly IEnumerable<IProblem> problemList;
        private readonly string examName;

        public Exam(string examName, IEnumerable<IProblem> problemList)
        {
            this.examName = examName;
            this.problemList = problemList;


        }

        public double Dificulty
        {
            get
            {
                return this.problemList.Average(p => p.Dificulty);
            }
        }

        public string Name
        {
            get
            {
                return this.examName;
            }
        }

        public IEnumerable<IProblem> ProblemList
        {
            get
            {
                return this.problemList;
            }
        }

        public void RestoreHP(IStudent student)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Exam: {this.Name} Dificulty: {this.Dificulty} Problems: {string.Join(Environment.NewLine, this.problemList)}";
        }
    }
}
