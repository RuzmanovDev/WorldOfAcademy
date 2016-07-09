namespace GameObjects.Contracts.Engine
{
    public interface ITrainerFactory
    {
        ITrainer CreateCurrentYearTrainer(string name, IExam exam);
        ITrainer CreatePreviousTrainer();
    }
}
