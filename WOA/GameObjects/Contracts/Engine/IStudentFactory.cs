namespace GameObjects.Contracts.Engine
{
    public interface IStudentFactory
    {
        IStudent CreateStudent(string name, int hp, int energy); //TODO: Add speicific parameters to the constructor;
    }
}
