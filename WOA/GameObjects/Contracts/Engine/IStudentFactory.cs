namespace GameObjects.Contracts.Engine
{
    public interface IStudentFactory
    {
        IStudent CreateStudent(string name); //TODO: Add speicific parameters to the constructor;
    }
}
