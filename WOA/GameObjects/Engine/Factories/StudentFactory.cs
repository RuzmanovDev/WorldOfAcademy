namespace GameObjects.Engine.Factories
{
    using System;

    using GameObjects.Contracts;
    using GameObjects.Contracts.Engine;
    using Models;
    public class StudentFactory : IStudentFactory
    {
        public IStudent CreateStudent(string name, int hp, int energy)
        {
            return new Student(name, hp, energy);
        }
    }
}
