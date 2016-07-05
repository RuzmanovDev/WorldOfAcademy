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
        private readonly int examDificulty = 0;
        private readonly string examName;

        public Exam(string examName, IEnumerable<IProblem> problemList)
        {
            this.examName = examName;
            this.problemList = problemList;

            foreach (var problem in this.problemList)
            {
                examDificulty += problem.Dificulty;
            }
        }

        public int Dificulty
        {
            get
            {
                return this.examDificulty;
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
