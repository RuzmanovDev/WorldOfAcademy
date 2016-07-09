namespace GameObjects.Contracts
{
    using GameObjects.Contracts;
    using GameObjects.Enumerations;

    public interface IStudent : IHuman
    {
        string HandleExam(IExam exam);

        IKnowledge Knowledge { get; }

        StudentType StudentType { get; }

        OtherCompetence OtherCompetence { get; }

        void ReceiveKnowledge(double knowledge);

        IPet Pet { get; }

        string GetHelp();
    }
}