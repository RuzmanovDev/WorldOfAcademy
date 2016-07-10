namespace GameObjects.Engine.Factories
{
    using System;

    using GameObjects.Contracts;
    using GameObjects.Contracts.Engine;
    using Models;
    using Enumerations;
    using Common;
    using Models.Stats;
    public class StudentFactory : IStudentFactory
    {
        public IStudent CreateStudent(string name, IPet pet)
        {
            var studentType = GenerateStudentype();
            var otherCompetance = GenerateOtherCompetance();

            var knowledge = GenerateInitialKnowedge(studentType, otherCompetance);

            return new Student(name, pet, studentType, otherCompetance, knowledge);
        }

        private OtherCompetence GenerateOtherCompetance()
        {
            var otherCompetence = (OtherCompetence)RandomProvider.Instance.Next(0, 5);
            return otherCompetence;
        }

        private StudentType GenerateStudentype()
        {
            int studentTypeRandGen = RandomProvider.Instance.Next(0, 2);

            StudentType studentType = (StudentType)studentTypeRandGen;

            return studentType;
        }

        private IKnowledge GenerateInitialKnowedge(StudentType studentType, OtherCompetence otherCompetence)
        {
            double initial = 0;

            if (studentType != StudentType.ThisYearStudent)
            {
                initial = 10;
            }
            initial = RandomProvider.Instance.Next(10, 21) + initial + (int)otherCompetence;

            IKnowledge knowledge = new KnowledgeStats(initial);

            return knowledge;
        }
    }
}