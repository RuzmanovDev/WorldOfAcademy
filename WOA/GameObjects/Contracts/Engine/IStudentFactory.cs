namespace GameObjects.Contracts.Engine
{
    public interface IStudentFactory
    {
        IStudent CreateStudent(string name, IPet pet); 


    }
}
