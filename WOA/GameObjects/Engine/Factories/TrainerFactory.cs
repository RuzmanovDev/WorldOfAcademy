namespace GameObjects.Engine.Factories
{
    using Contracts;
    using GameObjects.Contracts.Engine;
    using Models;

    public class TrainerFactory : ITrainerFactory
    {
        public ITrainer CreateCurrentYearTrainer(string name, IExam exam)
        {
            return new CurrentYearTrainer(name, exam);
        }

        public ITrainer CreatePreviousTrainer(string name)
        {
            return new PreviousYearTrainer(name);
        }

    }
}
