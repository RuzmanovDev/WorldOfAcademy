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
            string[] exams = {"CSharp part one", "CSharp part two", "OOP", "КПК", "DSA","HTML","CSS","JS Fundamentals","JS OOP",
            "JS UI & DOM", "JsApp", "DataBases", "ASP.NET Web Forms", "MMApp with NativeScript", "App for Windows",
                "Mobile App for iPhone & iPad", "Mobile App for Android", "End-to-End JavaScript Applications", "ASP.NET MVC"};

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
