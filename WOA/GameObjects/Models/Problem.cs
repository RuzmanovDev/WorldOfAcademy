namespace GameObjects.Models
{
    using Contracts;
    using Enumerations;

    public class Problem : IProblem
    {
        private readonly string name;
        private readonly double dificulty;
        private readonly ProblemType problemType;

        public Problem(string name, ProblemType problemType, int dificulty)
        {
            this.name = name;
            this.problemType = problemType;
            this.dificulty = dificulty;
        }

        public double Dificulty
        {
            get
            {
                return this.dificulty;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

        }

        public ProblemType ProblemType
        {
            get
            {
                return this.problemType;
            }
        }

        public void GiveKnowledge(IStudent st)
        {
            // TODO maybe another formula --- Dificulty / 10
            st.ReceiveKnowledge(this.Dificulty / 5);
        }

        public override string ToString()
        {
            return $"Problem: {this.Name} Type: {this.ProblemType} Dificulty: {this.Dificulty}";
        }
    }
}
