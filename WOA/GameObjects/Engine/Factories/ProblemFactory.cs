namespace GameObjects.Engine.Factories
{
    using GameObjects.Contracts.Engine;
    using GameObjects.Contracts;
    using Common;
    using Models;
    using Enumerations;

    class ProblemFactory : IProblemFactory
    {
        private const int ProblemTypeMaxCount = 9;
        private const int DificultyCoeff = 5;

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

            string[] problemNames = {"Kot-takoa","Malko Kote", "Card Wars Batka", "Penguin Airlines", "Batman", "Bobi-avokadoto", "Harry-Potter -20D",
                "Singing Cats", "Chess-moves","Hills","Brackets","Brackets again", "Pipes","Mices","Na baba mi smetalnika","Angry bits", "Cats singing","De-cat coding", "Maslan",
            "Two girls one path" , "Bit-shift Matrix", "Doge Coin","RelevanceIndex", "Digits", "Console game Horse Spirit", "Tulips in the Garden", "Lets count!",
            "Academy Catalogs", "Items control", "Datepicker", "Calendar template", "MinMax", "Triathlon", "Powers", "Cookie Super Styles", "Ocean crossing",
            "Bulgarian Fibonacci Sequence", "UFO watching", "Archimedes low in Spase", "Alf walkings", "Safe the Queen!", "Alien fights", "DNA mutation" };

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
