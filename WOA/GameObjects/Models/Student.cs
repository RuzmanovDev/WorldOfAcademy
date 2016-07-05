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

        private int knowledge;
        private  readonly StudentType studentType;

        public Student(string name)
            : base(name,Student.StudentBaseHp)
        {
            // generate random number and cast it to enum
            int studentTypeRandGen = RandomProvider.Instance.Next(0, 4);

            this.studentType = (StudentType)studentTypeRandGen;
            this.Knowledge = GenerateInitialKnowedge(this.StudentType);
        }

        private int GenerateInitialKnowedge(StudentType studentType)
        {
            return RandomProvider.Instance.Next(10, 21) + ((int)this.StudentType+15) * StudentTypeKnowedgeBooseKoef;
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

        public void HandleProblem(IProblem problem)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return $"Student Name: {this.Name} HP: {this.HP} StudentType: {this.studentType} Knowedge: {this.Knowledge}";
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
