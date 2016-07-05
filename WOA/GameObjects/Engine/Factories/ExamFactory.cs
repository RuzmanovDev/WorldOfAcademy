namespace GameObjects.Engine.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Contracts;
    using Contracts.Engine;
    using Common;
    using Models;

    public class ExamFactory : IExamFactory
    {
        private const int NumberOfProblemsInExam = 5;

        public IExam CreateExam()
        {
            var name = GeneratExamName();
            var problems = GenerateProblemList();

            return new Exam(name, problems);
        }

        private string GeneratExamName()
        {
            // TODO: add more exams
            string[] exams = {"CSharp part one", "CSharp part two", "OOP", "КПК", "DSA","HTML","CSS","JS Fundamentals","JS OOP",
            "JS UI & DOM", "JsApp", "DataBases"};

            string name = exams[RandomProvider.Instance.Next(0, exams.Length)]; // maybe -1

            return name;
        }

        private ICollection<IProblem> GenerateProblemList()
        {
            ICollection<IProblem> problems = new List<IProblem>();

            IProblemFactory problemFactory = new ProblemFactory();

            for (int i = 0; i < NumberOfProblemsInExam; i++)
            {
                problems.Add(problemFactory.CreateProblem());
            }

            return problems;
        }
    }
}
