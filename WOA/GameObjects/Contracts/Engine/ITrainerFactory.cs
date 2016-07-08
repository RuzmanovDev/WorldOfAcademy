namespace GameObjects.Contracts.Engine
{
    public interface ITrainerFactory
    {
        ITrainer CreateTrainer(string name, IExam exam);
    }
}
