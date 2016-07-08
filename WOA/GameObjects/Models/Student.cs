using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameObjects.Contracts;
using GameObjects.Enumerations;
using GameObjects.Models.Abstract;
using GameObjects.Common;

namespace GameObjects.Models
{
    public class Student : Human, IStudent
    {
        private const int StudentBaseHp = 100;
        private const int StudentTypeKnowedgeBooseKoef = 5;
        private const int Baseknowledge = 10;

        private int knowledge;
        private  readonly StudentType studentType;
        private readonly OtherCompetence otherCompetence;
        private readonly IPet pet;

        public Student(string name,IPet pet)
            : base(name,Student.StudentBaseHp)
        {
            // generate random number and cast it to enum
            int studentTypeRandGen = RandomProvider.Instance.Next(0, 2);

            this.studentType = (StudentType)studentTypeRandGen;
            this.Knowledge = GenerateInitialKnowedge(this.StudentType);
            this.otherCompetence = (OtherCompetence)RandomProvider.Instance.Next(0, 5);
            this.pet = pet;

        }

        private int GenerateInitialKnowedge(StudentType studentType)
        {
            int initial = 0;

            if(studentType != StudentType.ThisYearStudent)
            {
                initial = 10;
            }


            return RandomProvider.Instance.Next(10, 21) + initial + (int)this.OtherCompetence;
        }

        public int Knowledge
        {
            get
            {
                return this.knowledge;
            }

            private set
            {
                this.knowledge = value;
            }
        }

        public StudentType StudentType
        {
            get
            {
                return this.studentType;
            }
        }

        public OtherCompetence OtherCompetence
        {
            get
            {
                return otherCompetence;
            }
        }

        public IPet Pet
        {
            get
            {
                return this.pet;
            }
        }

        public void HandleProblem(IProblem problem)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return $"Student Name: {this.Name} HP: {this.HP} StudentType: {this.studentType} Competence: {this.OtherCompetence} Pet: {this.Pet} Knowledge: {this.Knowledge}";
        }

        public void ReceiveKnowledge(int knowledge)
        {
            this.Knowledge += knowledge;
        }

        public void ReceiveHP(int hp)
        {
            this.HP += hp;
        }
    }
}
