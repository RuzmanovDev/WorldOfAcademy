namespace GameObjects.Engine.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameObjects.Contracts.Engine;
    using GameObjects.Contracts;
    using Common;
    using Models;
    using Enumerations;

    class ProblemFactory : IProblemFactory
    {
        private const int ProblemTypeMaxCount = 9;
        private const int DificultyCoeff = 2;

        public IProblem CreateProblem()
        {
            var name = NameGenerator();
            var problemType = ProblemTypeGenerator();
            var dificulty = ProblemDificultyGenerator(problemType);

            return new Problem(name,problemType,dificulty);
        }

        private string NameGenerator()
        {
            string name = "";

            // TODO: add more problems to the examlist
            string[] problemNames = {"Kot-takoa","Malko Kote", "Card Wars Batka", "Penguin Airlines", "Batman", "Bobi-avokadoto", "Harry-Potter -20D",
                "Singing Cats"};

            name = problemNames[RandomProvider.Instance.Next(0, problemNames.Length)]; // maybe -1

            return name;
        }

        private ProblemType ProblemTypeGenerator()
        {
            // +1 because rand is not inclusive
            int rand = RandomProvider.Instance.Next(0, ProblemTypeMaxCount + 1);

            return (ProblemType)rand;
        }

        private int ProblemDificultyGenerator(ProblemType problemType)
        {
            return DificultyCoeff * (int)problemType;
        }


    }
}
