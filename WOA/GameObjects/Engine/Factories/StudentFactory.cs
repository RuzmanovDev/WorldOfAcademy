namespace GameObjects.Engine.Factories
{
    using System;

    using GameObjects.Contracts;
    using GameObjects.Contracts.Engine;
    using Models;
    public class StudentFactory : IStudentFactory
    {
        public IStudent CreateStudent(string name)
        {
            return new Student(name);
        }
    }
}
